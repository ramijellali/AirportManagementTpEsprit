using AM.applicationcore.Domain;
using AM.applicationcore.Interfaces;
using System;
using System.Collections.Generic;

namespace AM.applicationcore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();

            /*for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                {
                    flightDates.Add(Flights[i].FlightDate);
                }
            }*/
            foreach (flight in Flights) {

            return flightDates;
        }
    }
}
