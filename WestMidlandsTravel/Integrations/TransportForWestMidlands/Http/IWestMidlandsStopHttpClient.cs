using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;

public interface IWestMidlandsStopHttpClient
{
   Task<WestMidlandsPredictionsResponse> GetPredictions(string lineId);
   Task<WestMidlandsStopPointResponse> GetStopPoints(string lineId);
}