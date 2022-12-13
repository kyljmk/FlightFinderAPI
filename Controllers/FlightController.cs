
using FlightFinderAPI.Data;
using FlightFinderAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlightFinderAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FlightsController : ControllerBase
{
    private IFlightRepository _repo;

    public FlightsController(IFlightRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<SearchResponse>>> GetFlight([FromQuery] SearchRequest request)
    {
        var flights = await _repo.GetFlights(request);

        return Ok(flights);
    }
}
