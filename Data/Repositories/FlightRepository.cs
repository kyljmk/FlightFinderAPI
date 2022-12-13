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

    public async Task<List<Flight>> GetAllFlights()
    {
        var flights = await _context.Flights.Include(f => f.Itineraries)
            .ThenInclude(f => f.Prices)
            .Select(f => f)
            .ToListAsync();

        return flights;
    }

    public async Task<List<SearchResponse>> GetFlights(SearchRequest request)
    {
        var flights = new List<SearchResponse>();

        var flightsTo = await _context.Flights.Include(f => f.Itineraries)
            .ThenInclude(f => f.Prices)
            .Where(f => f.DepartureDestination == request.Departure)
            .Where(f => f.ArrivalDestination == request.Arrival)
            .Select(f => new SearchResponse()
            {
                Id = f.Id,
                DepartureDestination = f.DepartureDestination,
                ArrivalDestination = f.ArrivalDestination,
                Itineraries = FilterItineraries(f.Itineraries, request, false)
            })
            .FirstAsync();

        flights.Add(flightsTo);

        if (request.Option == "Return")
        {
            var flightsFrom = await _context.Flights.Include(f => f.Itineraries)
            .ThenInclude(f => f.Prices)
            .Where(f => f.DepartureDestination == request.Arrival)
            .Where(f => f.ArrivalDestination == request.Departure)
            .Select(f => new SearchResponse()
            {
                Id = f.Id,
                Itineraries = FilterItineraries(f.Itineraries, request, true)
            })
            .FirstAsync();

            flights.Add(flightsFrom);
        }

        return flights;
    }

    private static List<Itinerary> FilterItineraries(List<Itinerary> itineraries, SearchRequest request, bool returnFlight)
    {
        var totalBookings = request.Adults + request.Children;
        var newItineraries = new List<Itinerary>();

        var flightDay = returnFlight ? request.EndDate.Day : request.StartDate.Day;

        foreach (Itinerary i in itineraries)
        {
            if (i.DepartureTime.Day == flightDay && i.AvailableSeats >= totalBookings)
            {
                newItineraries.Add(i);
            }
        }

        return newItineraries;
    }
}