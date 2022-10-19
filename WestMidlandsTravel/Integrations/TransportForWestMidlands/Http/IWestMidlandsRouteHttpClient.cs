using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;

public interface IWestMidlandsRouteHttpClient
{
   Task<WestMidlandsRouteResponse> GetLines();
   Task<WestMidlandsRouteResponse> GetRoutesForLine(string lineId);
}