using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Services;

public interface IRouteService
{
    Task<IEnumerable<Line>> FetchAllRoutes();
    Task<WestMidlandsRouteResponse>FetchRoutesByLineId(string lineId);
}