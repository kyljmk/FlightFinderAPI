using System.ComponentModel.DataAnnotations;

namespace FlightFinderAPI.Models;

public class Itinerary
{
    public Guid Id { get; set; }
    [DataType(DataType.Date)]
    public DateTime DepartureTime { get; set; }
    [DataType(DataType.Date)]
    public DateTime ArrivalTime { get; set; }
    public int AvailableSeats { get; set; }
    public Prices Prices { get; set; }
}