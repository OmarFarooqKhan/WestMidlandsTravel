using WestMidlandsTravel.Models.ApiModels.WestMidlands.Response.StopPoint;

namespace WestMidlandsTravel.BusinessLayer;

public interface IStopService
{
    Task<IEnumerable<StopPoint>> GetStopPredictionsAsync(string stopId);
    Task<IEnumerable<StopPoint>> GetStopPointsAsync(string lineId);
}