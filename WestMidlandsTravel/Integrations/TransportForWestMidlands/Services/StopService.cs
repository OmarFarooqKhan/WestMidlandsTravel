using WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.Services;

public class StopService : IStopService
{
    private readonly IWestMidlandsStopHttpClient _stopHttpClient;

    public StopService(IWestMidlandsStopHttpClient stopHttpClient)
    {
        _stopHttpClient = stopHttpClient;
    }
    
    public async Task<IEnumerable<StopPoint>> GetStopPredictionsAsync(string stopId)
    {
        var response = await _stopHttpClient.GetPredictions(stopId);
        var stopPoints =  response.ArrayOfStopPoint.StopPoint;
        return stopPoints;
    }

    public async Task<IEnumerable<StopPoint>> GetStopPointsAsync(string lineId)
    {
        var response = await _stopHttpClient.GetStopPoints(lineId);
        var stopPoints = response.ArrayOfStopPoint.StopPoint;
        return stopPoints;
    }
}