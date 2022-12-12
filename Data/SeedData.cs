// using Microsoft.EntityFrameworkCore;
// using FlightFinderAPI.Models;

// namespace FlightFinderAPI.Data;

// public static class SeedData
// {
//     public static void Initialize(IServiceProvider serviceProvider)
//     {
//         using (var context = new FlightContext(
//             serviceProvider.GetRequiredService<DbContextOptions<FlightContext>>()))
//         // Look for any movies.
//         {
//             if (context.Flights.Any()) { return; }
//             context.Flights.AddRange(
//                 new Flight
//                 {
//                     Id = "S83195",
//                     DepartureDestination = "Stockholm",
//                     ArrivalDestination = "Oslo",
//                     Itineraries = new List<Itinerary>()
//                     {
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 13, 30, 0),
//                             AvailableSeats = 2,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 16, 30, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 19, 30, 0),
//                             AvailableSeats = 0,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 22, 30, 0),
//                             AvailableSeats = 20,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 13, 30, 0),
//                             AvailableSeats = 1,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 16, 30, 0),
//                             AvailableSeats = 53,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 19, 30, 0),
//                             AvailableSeats = 50,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 22, 30, 0),
//                             AvailableSeats = 15,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 13, 30, 0),
//                             AvailableSeats = 1,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 16, 30, 0),
//                             AvailableSeats = 53,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 19, 30, 0),
//                             AvailableSeats = 50,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 22, 30, 0),
//                             AvailableSeats = 0,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 13, 30, 0),
//                             AvailableSeats = 1,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 16, 30, 0),
//                             AvailableSeats = 53,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 19, 30, 0),
//                             AvailableSeats = 50,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 22, 30, 0),
//                             AvailableSeats = 0,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 13, 30, 0),
//                             AvailableSeats = 10,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 500}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 16, 30, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2300, Child = 550}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 19, 30, 0),
//                             AvailableSeats = 30,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2300, Child = 550}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 22, 30, 0),
//                             AvailableSeats = 2,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 400}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 17, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 17, 19, 30, 0),
//                             AvailableSeats = 3,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 3000, Child = 700}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 17, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 17, 22, 30, 0),
//                             AvailableSeats = 10,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2300, Child = 400}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 18, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 13, 30, 0),
//                             AvailableSeats = 10,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 3400, Child = 800}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 18, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 16, 30, 0),
//                             AvailableSeats = 1,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 3700, Child = 770}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 18, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 19, 30, 0),
//                             AvailableSeats = 40,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 4000, Child = 800}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 18, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 22, 30, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2200, Child = 300}
//                         },
//                     }
//                 },
//                 new Flight
//                 {
//                     Id = "B83195",
//                     DepartureDestination = "Oslo",
//                     ArrivalDestination = "Stockholm",
//                     Itineraries = new List<Itinerary>()
//                     {
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 11, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 12, 0, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1300, Child = 325}
//                         },
//                         new Itinerary
//                             {
//                             DepartureTime = new DateTime(2022, 12, 12, 13, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 14, 0, 0),
//                             AvailableSeats = 10,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                             {
//                             DepartureTime = new DateTime(2022, 12, 12, 16, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 17, 0, 0),
//                             AvailableSeats = 3,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1300, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 22, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 23, 0, 0),
//                             AvailableSeats = 20,
//                             Prices = new Prices
//                               { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 14, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 15, 0, 0),
//                             AvailableSeats = 2,
//                             Prices = new Prices
//                                { Currency = "SEK", Adult = 2000, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 14, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 15, 0, 0),
//                             AvailableSeats = 10,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2100, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 14, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 15, 0, 0),
//                             AvailableSeats = 2,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 14, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 15, 0, 0),
//                             AvailableSeats = 9,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 17, 14, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 17, 15, 0, 0),
//                             AvailableSeats = 33,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1800, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 19, 22, 0, 0),
//                             ArrivalTime = new DateTime(2022, 12, 19, 23, 0, 0),
//                             AvailableSeats = 2,
//                             Prices = new Prices
//                               { Currency = "SEK", Adult = 3000, Child = 600}
//                         },
//                     }
//                 },
//                 new Flight
//                 {
//                     Id = "C83195",
//                     DepartureDestination = "Oslo",
//                     ArrivalDestination = "Amsterdam",
//                     Itineraries = new List<Itinerary>()
//                     {
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 14, 0, 0),
//                             AvailableSeats = 12,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 17, 0, 0),
//                             AvailableSeats = 15,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 20, 0, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 23, 0, 0),
//                             AvailableSeats = 20,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 14, 0, 0),
//                             AvailableSeats = 1,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 17, 0, 0),
//                             AvailableSeats = 53,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 20, 0, 0),
//                             AvailableSeats = 50,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 23, 0, 0),
//                             AvailableSeats = 15,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 14, 0, 0),
//                             AvailableSeats = 1,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 17, 0, 0),
//                             AvailableSeats = 53,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 20, 0, 0),
//                             AvailableSeats = 50,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 23, 0, 0),
//                             AvailableSeats = 0,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 14, 0, 0),
//                             AvailableSeats = 1,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 17, 0, 0),
//                             AvailableSeats = 53,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1500, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 20, 0, 0),
//                             AvailableSeats = 50,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 23, 0, 0),
//                             AvailableSeats = 0,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 14, 0, 0),
//                             AvailableSeats = 10,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 500}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 17, 0, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2300, Child = 550}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 20, 0, 0),
//                             AvailableSeats = 30,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2330, Child = 550}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 23, 0, 0),
//                             AvailableSeats = 2,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 1900, Child = 400}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 17, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 17, 20, 0, 0),
//                             AvailableSeats = 3,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 3000, Child = 700}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 17, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 17, 23, 0, 0),
//                             AvailableSeats = 10,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2300, Child = 400}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 18, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 14, 0, 0),
//                             AvailableSeats = 10,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 3400, Child = 800}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 18, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 17, 0, 0),
//                             AvailableSeats = 1,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 3700, Child = 770}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 18, 18, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 20, 0, 0),
//                             AvailableSeats = 40,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 4000, Child = 800}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 18, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 23, 0, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2200, Child = 300}
//                         },
//                     }
//                 },
//                 new Flight
//                 {
//                     Id = "A83195",
//                     DepartureDestination = "Amsterdam",
//                     ArrivalDestination = "Oslo",
//                     Itineraries = new List<Itinerary>()
//                     {
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 10, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 12, 0, 0),
//                             AvailableSeats = 12,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2222, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 12, 17, 0, 0),
//                             AvailableSeats = 53,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2333, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 12, 23, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 01, 0, 0),
//                             AvailableSeats = 30,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 10, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 12, 0, 0),
//                             AvailableSeats = 3,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 13, 17, 0, 0),
//                             AvailableSeats = 3,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2333, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 13, 23, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 01, 0, 0),
//                             AvailableSeats = 12,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2333, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 10, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 12, 0, 0),
//                             AvailableSeats = 1,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2333, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 14, 17, 0, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2333, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 14, 23, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 01, 0, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2333, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 10, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 12, 0, 0),
//                             AvailableSeats = 11,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 15, 17, 0, 0),
//                             AvailableSeats = 3,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 15, 23, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 01, 0, 0),
//                             AvailableSeats = 50,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 325}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 10, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 12, 0, 0),
//                             AvailableSeats = 7,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2000, Child = 500}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 15, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 16, 17, 0, 0),
//                             AvailableSeats = 5,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2300, Child = 550}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 16, 23, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 17, 01, 0, 0),
//                             AvailableSeats = 30,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2330, Child = 550}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 17, 12, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 17, 14, 0, 0),
//                             AvailableSeats = 9,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 3333, Child = 900}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 17, 23, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 01, 0, 0),
//                             AvailableSeats = 10,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 2300, Child = 400}
//                         },
//                         new Itinerary
//                         {
//                             DepartureTime = new DateTime(2022, 12, 18, 21, 30, 0),
//                             ArrivalTime = new DateTime(2022, 12, 18, 23, 0, 0),
//                             AvailableSeats = 33,
//                             Prices = new Prices
//                                 { Currency = "SEK", Adult = 4000, Child = 800}
//                         },
//                     }
//                 }
//             );
//             context.SaveChanges();
//         }
//     }
// }