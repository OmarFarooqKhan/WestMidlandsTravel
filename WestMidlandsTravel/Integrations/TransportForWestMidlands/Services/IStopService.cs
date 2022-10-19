using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Services;

public interface IStopService
{
    Task<IEnumerable<Prediction>> GetStopPredictionsAsync(string stopId);
    Task<IEnumerable<StopPoint>> GetStopPointsAsync(string lineId);
}