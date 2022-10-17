using WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;

namespace WestMidlandsTravel.BusinessLayer;

public interface IRouteService
{
    Task<IEnumerable<Line>> FetchAllRoutes();
    Task<WestMidlandsRouteResponse>FetchRoutesByLineId(string lineId);
}