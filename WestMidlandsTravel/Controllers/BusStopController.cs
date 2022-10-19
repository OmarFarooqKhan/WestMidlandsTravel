using Microsoft.AspNetCore.Mvc;
using WestMidlandsTravel.Integrations.GTFSRealTime.Http;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;
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

    /// <summary>
    /// Gets arrival predictions for a specific stopId.
    /// </summary>
    /// <param name="stopId"></param>
    /// <returns></returns>
    [HttpGet("prediction/{stopId}")]
    [ProducesResponseType(typeof(IEnumerable<Prediction>), 200)]
    [ResponseCache(Duration = 30)]
    public async Task<IActionResult> GetStopPredictions(string stopId)
    {
        var output = await _stopService.GetStopPredictionsAsync(stopId);
        _logger.LogInformation("Successfully retrieved stop predictions for stopId {stopId}", stopId);
        return Ok(output);
    }
    
    /// <summary>
    /// Get the list of stops for a specific lineId.
    /// </summary>
    /// <param name="lineId"></param>
    /// <returns></returns>
    [HttpGet("StopPoints/{lineId}")]
    [ProducesResponseType(typeof(IEnumerable<StopPoint>), 200)]
    [ResponseCache(Duration = 30)]
    public async Task<IActionResult> GetStopPoints(string lineId)
    {
        var output = await _stopService.GetStopPointsAsync(lineId);
        return Ok(output);
    }
}