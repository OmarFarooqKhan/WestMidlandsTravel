using System.Net;
using Microsoft.AspNetCore.Mvc;
using WestMidlandsTravel.BusinessLayer;
using WestMidlandsTravel.Models.ApiModels;
using WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;

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

    [HttpGet("allRoutes")]
    [ProducesResponseType(typeof(Line), (int)HttpStatusCode.OK)]
    [ResponseCache(Duration = 30)]
    public async Task<IActionResult> GetAllRoutes()
    {
        var output = await _routeService.FetchAllRoutes();
        
        return Ok(output);
    }
    
    [HttpGet("{lineId}")]
    [ProducesResponseType(typeof(WestMidlandsRouteResponse), 200)]
    [ResponseCache(Duration = 30)]
    public async Task<IActionResult> GetRoutes(string lineId)
    {
        var output = await _routeService.FetchRoutesByLineId(lineId);
        return Ok(output);
    }
    
    
}