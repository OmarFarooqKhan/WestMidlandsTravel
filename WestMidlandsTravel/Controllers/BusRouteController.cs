using System.Net;
using Microsoft.AspNetCore.Mvc;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.Services;

namespace WestMidlandsTravel.Controllers;

public class BusRouteController : CustomController
{
    private readonly ILogger<BusRouteController> _logger;
    private readonly IRouteService _routeService;

    public BusRouteController(ILogger<BusRouteController> logger, IRouteService routeService)
    {
        _logger = logger;
        _routeService = routeService;
    }

    /// <summary>
    /// Gets all Lines.
    /// </summary>
    /// <returns></returns>
    [HttpGet("allLines")]
    [ProducesResponseType(typeof(Line), (int)HttpStatusCode.OK)]
    [ResponseCache(Duration = 30)]
    public async Task<IActionResult> GetAllLines()
    {
        var output = await _routeService.FetchAllLines();
        
        return Ok(output);
    }
    
    
    /// <summary>
    /// Gets a Route for a specific LineId.
    /// </summary>
    /// <param name="lineId"></param>
    /// <returns></returns>
    [HttpGet("{lineId}")]
    [ProducesResponseType(typeof(WestMidlandsRouteResponse), 200)]
    [ResponseCache(Duration = 30)]
    public async Task<IActionResult> GetRoutes(string lineId)
    {
        var output = await _routeService.FetchRoutesByLineId(lineId);
        return Ok(output);
    }
}