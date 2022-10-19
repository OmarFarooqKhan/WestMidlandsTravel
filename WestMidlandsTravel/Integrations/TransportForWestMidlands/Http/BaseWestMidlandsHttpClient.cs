using System.Net.Http.Headers;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WestMidlandsTravel.Startup.Configuration;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;

public class BaseWestMidlandsHttpClient
{
    private readonly HttpClient _client;
    private readonly ILogger<BaseWestMidlandsHttpClient> _logger;
    private readonly WestMidlandsTransportOptions _options;
    protected BaseWestMidlandsHttpClient(IOptions<WestMidlandsTransportOptions> options, HttpClient httpClient, ILogger<BaseWestMidlandsHttpClient> logger)
    {
        _client = httpClient;
        _logger = logger;
        _options = options.Value;
        _client = httpClient;
        _client.BaseAddress = new Uri(_options.Url);
        _client.Timeout = TimeSpan.FromMilliseconds(_options.Timeout);
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    
    protected async Task<T> Get<T>(string routePrefix, string route)
    {
        var definedRoute = SetupRouteQuery(routePrefix, route);
        try
        {
          //  var response = await _client.GetAsync(definedRoute);
          //  response.EnsureSuccessStatusCode();
          //  var responseString = await response.Content.ReadAsStringAsync();
          var path =
              "/Users/omar/RiderProjects/WestMidlandsTravel/WestMidlandsTravel/Integrations/TransportForWestMidlands/Http/response.json";
          var movie1 = JsonConvert.DeserializeObject<T>(await File.ReadAllTextAsync(path));

//            var westMidlandsRouteResponse = JsonConvert.DeserializeObject<T>();

            return movie1;
        }
        catch(TaskCanceledException ex)
        {
            _logger.LogError(ex, "Request timed out");
            throw;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Request failed");
            throw;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error getting routes");
            throw;
        }
    }
    private string SetupRouteQuery(string routePrefix, string route)
    {
        var query = new Dictionary<string, string>()
        {
            ["app_id"] = _options.ApiSecret,
            ["app_key"] = _options.ApiKey,
            ["formatter"] = "JSON"
        };
        return QueryHelpers.AddQueryString($"{routePrefix}/{route}", query);
    }
}