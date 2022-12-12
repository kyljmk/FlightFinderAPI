using System.ComponentModel.DataAnnotations;

namespace FlightFinderAPI.Models
{
    public class Prices
    {
        public Guid Id { get; set; }
        public string Currency { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
    }
}