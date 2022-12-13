namespace FlightFinderAPI.Models;

public class SearchRequest
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Option { get; set; }
    public string? Departure { get; set; }
    public string? Arrival { get; set; }
    public int Adults { get; set; }
    public int Children { get; set; }
}

public class SearchResponse
{
    public string? Id { get; set; }
    public List<Itinerary>? Itineraries { get; set; }
}