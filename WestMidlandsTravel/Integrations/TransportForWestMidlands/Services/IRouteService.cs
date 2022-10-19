using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Services;

public interface IRouteService
{
    Task<IEnumerable<Line>> FetchAllLines();
    Task<WestMidlandsRouteResponse>FetchRoutesByLineId(string lineId);
}