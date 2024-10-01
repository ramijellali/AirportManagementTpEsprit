using AM.applicationcore.Domain;
using AM.applicationcore.Interfaces;
using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AM.applicationcore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();
            // WITH THE FOR LOOP 

            /*for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                {
                    flightDates.Add(Flights[i].FlightDate);
                }
            }*/

            // WITH THE FOREACH LOOP
            /*foreach (var flight in Flights)
            {
                if (flight.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                {
                    flightDates.Add(flight.FlightDate);
                }
            }*/
          
                // Using LINQ to filter and select flight dates
                return Flights
                    .Where(flight => flight.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                    .Select(flight => flight.FlightDate)
                    .ToList();
            



            
        }
        public void GetFlights(string filterType, string filterValue)
        {
            var filteredFlights = new List<Flight>();

            foreach (var flight in Flights)
            {
                // Check the filter type and apply the corresponding condition
                switch (filterType.ToLower())
                {
                    case "destination":
                        if (flight.Destination.Equals(filterValue, StringComparison.OrdinalIgnoreCase))
                        {
                            filteredFlights.Add(flight);
                        }
                        break;

                    case "flightdate":
                        if (flight.FlightDate.ToShortDateString().Equals(filterValue))
                        {
                            filteredFlights.Add(flight);
                        }
                        break;

                    case "estimatedduration":
                        if (flight.EstimatedDuration.ToString().Equals(filterValue))
                        {
                            filteredFlights.Add(flight);
                        }
                        break;

                    // Add more cases for other filter types as needed

                    default:
                        Console.WriteLine("Invalid filter type.");
                        return;
                }
            }

            // Display the filtered flights
            if (filteredFlights.Count > 0)
            {
                Console.WriteLine("Filtered Flights:");
                foreach (var flight in filteredFlights)
                {
                    Console.WriteLine($"Destination: {flight.Destination}, Flight Date: {flight.FlightDate}, Estimated Duration: {flight.EstimatedDuration}");
                }
            }
            else
            {
                Console.WriteLine("No flights found matching the criteria.");
            }
        }
        public List<(DateTime FlightDate, string Destination)> ShowFlightDetails(Plane plane)
        {
            return Flights
                .Where(flight => flight.Plane.PlaneId == plane.PlaneId)  // Compare flight's plane ID with the given plane's ID
                .Select(flight => (flight.FlightDate, flight.Destination)) // Select both FlightDate and Destination
                .ToList();
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            DateTime enddate = startDate.AddDays(7);
            return Flights.Count
                (flight => flight.FlightDate >= startDate && flight.FlightDate <= enddate);
        }
        public double DurationAverage(string destination)
        {
            return Flights.
                Where(flight=>flight.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                .Select(flight=>flight.EstimatedDuration)
                .Average();
        }
            public List<Flight> OrderedDurationFlights()
            {
                return Flights.OrderBy(flight=>flight.EstimatedDuration).ToList();
            }
    }
}
