using Microsoft.AspNetCore.Mvc;
using WestMidlandsTravel.Integrations.GTFSRealTime.Http;

namespace WestMidlandsTravel.Controllers;

public class BusUpdatesController : CustomController
{
    private readonly IGtfsRealTimeHttpClient _httpClient;
    private readonly ILogger<BusUpdatesController> _logger;

    public BusUpdatesController(ILogger<BusUpdatesController> logger, IGtfsRealTimeHttpClient httpClient)
    {
        _logger = logger;
        _httpClient = httpClient;
    }

    /// <summary>
    /// Gets a snapshot of the current bus network
    /// </summary>
    /// <returns></returns>
    [HttpGet("tripupdates/")]
    [ResponseCache(Duration = 120)]
    public async Task<IActionResult> GetStopPredictions(int start = 0, int end = 10)
    {
        var response = await _httpClient.GetAsync("trip_updates");
        _logger.LogInformation("Got response from GTFS Realtime API");
        return Ok(response.Take(new Range(start, end)));
    }

    /// <summary>
    /// Gets a tripId
    /// </summary>
    /// <returns></returns>
    [HttpGet("tripId/")]
    [ResponseCache(Duration = 120)]
    public async Task<IActionResult> GetStopPredictionsById(int routeId)
    {
        var response = await _httpClient.GetAsync("trip_updates");
        var outcome = response.First(entry => entry.TripUpdate.Trip.RouteId == routeId.ToString());
        _logger.LogInformation("Got response from GTFS Realtime API");
        return Ok(outcome);
    }
}