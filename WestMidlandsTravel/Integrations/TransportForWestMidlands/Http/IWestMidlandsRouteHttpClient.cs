using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;

public interface IWestMidlandsRouteHttpClient
{
   Task<WestMidlandsRouteResponse> GetAllRoutes();
   Task<WestMidlandsRouteResponse> GetRoutesForLine(string lineId);
}