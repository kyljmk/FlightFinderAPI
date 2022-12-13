using FlightFinderAPI.Models;

namespace FlightFinderAPI.Data;

public interface IFlightRepository
{
    Task<List<Flight>> GetAllFlights();
    Task<List<SearchResponse>> GetFlights(SearchRequest request);
}