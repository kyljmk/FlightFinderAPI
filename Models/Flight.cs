namespace FlightFinderAPI.Models;

public class Flight
{
    public string Id { get; set; }
    public string DepartureDestination { get; set; }
    public string ArrivalDestination { get; set; }
    public List<Itinerary> Itineraries { get; set; }
}