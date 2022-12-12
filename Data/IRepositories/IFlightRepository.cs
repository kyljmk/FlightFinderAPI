using FlightFinderAPI.Models;

namespace FlightFinderAPI.Data;

public interface IFlightRepository
{
    Task<List<Flight>> GetFlights();
}