using Microsoft.Extensions.Options;
using WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;
using WestMidlandsTravel.Startup.Configuration;

namespace WestMidlandsTravel.Http;

public class WestMidlandsRouteLineHttpClient : BaseWestMidlandsHttpClient, IWestMidlandsRouteHttpClient
{
    private const string RoutePrefix = "Line";

    public WestMidlandsRouteLineHttpClient(IOptions<WestMidlandsTransportOptions> options, HttpClient httpClient,
        ILogger<WestMidlandsRouteLineHttpClient> logger) : base(options, httpClient, logger)
    {
    }

    public async Task<WestMidlandsRouteResponse> GetAllRoutes()
    {
        return await Get<WestMidlandsRouteResponse>(RoutePrefix,"Route/");
    }

    public async Task<WestMidlandsRouteResponse> GetRoutesForLine(string lineId)
    {
        return await Get<WestMidlandsRouteResponse>(RoutePrefix,$"{lineId}/Route/");
    }
}