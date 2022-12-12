using Microsoft.EntityFrameworkCore;
using FlightFinderAPI.Models;

namespace FlightFinderAPI.Data;

public class FlightContext : DbContext
{
    public FlightContext(DbContextOptions<FlightContext> options)
        : base(options)
    {
    }

    public DbSet<Flight>? Flights { get; set; }
}