using WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Services;

public class RouteService : IRouteService
{
    private readonly IWestMidlandsRouteHttpClient _routeHttpClient;

    public RouteService(IWestMidlandsRouteHttpClient routeHttpClient)
    {
        _routeHttpClient = routeHttpClient;
    }
    public async Task<IEnumerable<Line>> FetchAllRoutes()
    {
        var route = await _routeHttpClient.GetAllRoutes();
       var allRoutes = route.ArrayOfLine.Line; 
       return allRoutes;
    }
    
    public async Task<WestMidlandsRouteResponse> FetchRoutesByLineId(string lineId)
    {
        var route = await _routeHttpClient.GetRoutesForLine(lineId);
        return route;
    }
    
}