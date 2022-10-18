using System.Net.Http.Headers;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using TransitRealtime;
using WestMidlandsTravel.Startup.Configuration;

namespace WestMidlandsTravel.Integrations.GTFSRealTime.Http;


public class GtfsRealTimeHttpClient : IGtfsRealTimeHttpClient
{
    private readonly GtfsRealtimeOptions _options;
    private readonly HttpClient _client;
    
    public GtfsRealTimeHttpClient(IOptions<GtfsRealtimeOptions> options, HttpClient client)
    {
        _options = options.Value;
        _options = options.Value;
        _client = client;
        _client.BaseAddress = new Uri(_options.Url);
        _client.Timeout = TimeSpan.FromMilliseconds(_options.Timeout);
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/octet-stream"));
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-protobuf"));
    }
    
    public async Task<IEnumerable<FeedEntity>> GetAsync(string url)
    {
        var authenticatedUrl = SetupRouteQuery("gtfs", url);
        var response =  await _client.GetAsync(authenticatedUrl);
        
        var feedMessage = FeedMessage.Parser.ParseFrom(await response.Content.ReadAsByteArrayAsync());
        return  feedMessage.Entity.ToList();
    }
    
    private string SetupRouteQuery(string routePrefix, string route)
    {
        var query = new Dictionary<string, string>()
        {
            ["app_id"] = _options.ApiSecret,
            ["app_key"] = _options.ApiKey
        };
        return QueryHelpers.AddQueryString($"{routePrefix}/{route}", query);
    }
}