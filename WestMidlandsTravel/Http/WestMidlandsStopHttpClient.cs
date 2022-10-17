using Microsoft.Extensions.Options;
using WestMidlandsTravel.Models.ApiModels.WestMidlands.Response.StopPoint;
using WestMidlandsTravel.Startup.Configuration;

namespace WestMidlandsTravel.Http;

public class WestMidlandsStopHttpClient : BaseWestMidlandsHttpClient, IWestMidlandsStopHttpClient
{
    private const string RoutePrefix = "StopPoint";
    public WestMidlandsStopHttpClient(IOptions<WestMidlandsTransportOptions> options, HttpClient httpClient,
        ILogger<WestMidlandsStopHttpClient> logger) : base(options, httpClient, logger)
    {
    }

    public async Task<WestMidlandsStopPointResponse> GetPredictions(string lineId)
    {
      return await Get<WestMidlandsStopPointResponse>(RoutePrefix, $"{lineId}/Arrivals");
    }

    public async Task<WestMidlandsStopPointResponse> GetStopPoints(string lineId)
    {
        return await Get<WestMidlandsStopPointResponse>("Line", $"{lineId}/StopPoints");
    }
}