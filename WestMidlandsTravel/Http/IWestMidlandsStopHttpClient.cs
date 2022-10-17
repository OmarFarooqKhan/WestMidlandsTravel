using WestMidlandsTravel.Models.ApiModels.WestMidlands.Response.StopPoint;

namespace WestMidlandsTravel.Http;

public interface IWestMidlandsStopHttpClient
{
   Task<WestMidlandsStopPointResponse> GetPredictions(string lineId);
   Task<WestMidlandsStopPointResponse> GetStopPoints(string lineId);
}