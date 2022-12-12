using FlightFinderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightFinderAPI.Data;

public class FlightRepository : IFlightRepository
{
    private FlightContext _context;

    public FlightRepository(FlightContext context)
    {
        _context = context;
    }

    public async Task<List<Flight>> GetFlights()
    {
        var flights = await _context.Flights.Include(f => f.Itineraries)
                                            .ThenInclude(f => f.Prices)
                                            .Select(f => f)
                                            .ToListAsync();

        return flights;
    }
}