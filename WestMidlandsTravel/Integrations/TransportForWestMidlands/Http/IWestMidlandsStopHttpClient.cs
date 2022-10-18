using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;

public interface IWestMidlandsStopHttpClient
{
   Task<WestMidlandsStopPointResponse> GetPredictions(string lineId);
   Task<WestMidlandsStopPointResponse> GetStopPoints(string lineId);
}