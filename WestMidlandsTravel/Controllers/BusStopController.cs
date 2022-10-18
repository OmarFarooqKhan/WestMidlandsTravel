using Microsoft.AspNetCore.Mvc;
using WestMidlandsTravel.Integrations.GTFSRealTime.Http;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.Services;

namespace WestMidlandsTravel.Controllers;

public class BusStopController : CustomController
{
    private readonly ILogger<BusStopController> _logger;
    private readonly IStopService _stopService;

    public BusStopController(ILogger<BusStopController> logger, IStopService stopService)
    {
        _logger = logger;
        _stopService = stopService;
    }

    [HttpGet("prediction/{stopId}")]
    [ProducesResponseType(typeof(IEnumerable<StopPoint>), 200)]
    [ResponseCache(Duration = 30)]
    public async Task<IActionResult> GetStopPredictions(string stopId)
    {
        var output = await _stopService.GetStopPredictionsAsync(stopId);
        return Ok(output);
    }
    
    [HttpGet("StopPoints/{lineId}")]
    [ProducesResponseType(typeof(IEnumerable<StopPoint>), 200)]
    [ResponseCache(Duration = 30)]
    public async Task<IActionResult> GetStopPoints(string lineId)
    {
        var output = await _stopService.GetStopPointsAsync(lineId);
        return Ok(output);
    }
}