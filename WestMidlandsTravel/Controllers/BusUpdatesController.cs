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
    [HttpGet("tripupdates/")]
    [ResponseCache(Duration = 30)]
    public async Task<IActionResult> GetStopPredictions()
    {
        var response = await _httpClient.GetAsync("trip_updates");
        _logger.LogInformation("Got response from GTFS Realtime API");
        return Ok(response);
    }
}