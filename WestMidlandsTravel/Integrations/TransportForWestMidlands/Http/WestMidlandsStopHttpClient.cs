using Microsoft.Extensions.Options;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;
using WestMidlandsTravel.Startup.Configuration;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;

public class WestMidlandsStopHttpClient : BaseWestMidlandsHttpClient, IWestMidlandsStopHttpClient
{
    private const string RoutePrefix = "StopPoint";
    public WestMidlandsStopHttpClient(IOptions<WestMidlandsTransportOptions> options, HttpClient httpClient,
        ILogger<WestMidlandsStopHttpClient> logger) : base(options, httpClient, logger)
    {
    }

    public async Task<WestMidlandsPredictionsResponse> GetPredictions(string lineId)
    {
      return await Get<WestMidlandsPredictionsResponse>(RoutePrefix, $"{lineId}/Arrivals");
    }

    public async Task<WestMidlandsStopPointResponse> GetStopPoints(string lineId)
    {
        return await Get<WestMidlandsStopPointResponse>("Line", $"{lineId}/StopPoints");
    }
}