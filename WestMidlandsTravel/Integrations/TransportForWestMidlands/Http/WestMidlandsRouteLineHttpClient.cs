using Microsoft.Extensions.Options;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;
using WestMidlandsTravel.Startup.Configuration;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;

public class WestMidlandsRouteLineHttpClient : BaseWestMidlandsHttpClient, IWestMidlandsRouteHttpClient
{
    private const string RoutePrefix = "Line";

    public WestMidlandsRouteLineHttpClient(IOptions<WestMidlandsTransportOptions> options, HttpClient httpClient,
        ILogger<WestMidlandsRouteLineHttpClient> logger) : base(options, httpClient, logger)
    {
    }

    public async Task<WestMidlandsRouteResponse> GetLines()
    {
        return await Get<WestMidlandsRouteResponse>(RoutePrefix,"Route/");
    }

    public async Task<WestMidlandsRouteResponse> GetRoutesForLine(string lineId)
    {
        return await Get<WestMidlandsRouteResponse>(RoutePrefix,$"{lineId}/Route/");
    }
}