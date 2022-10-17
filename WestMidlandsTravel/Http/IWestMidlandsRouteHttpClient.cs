using WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;

namespace WestMidlandsTravel.Http;

public interface IWestMidlandsRouteHttpClient
{
   Task<WestMidlandsRouteResponse> GetAllRoutes();
   Task<WestMidlandsRouteResponse> GetRoutesForLine(string lineId);
}