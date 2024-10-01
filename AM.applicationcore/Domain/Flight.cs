using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationcore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public virtual List<Passenger> Passengers { get; set; }
        public virtual Plane Plane { get; set; }

        public override string ToString()
        {
            return $"FlightId: {FlightId}, FlightDate: {FlightDate}, EstimatedDuration: {EstimatedDuration} mins, " +
                   $"EffectiveArrival: {EffectiveArrival}, Departure: {Departure}, Destination: {Destination}, " +
                   $"Plane: {Plane?.ToString() ?? "No plane assigned"}, Passengers: {Passengers?.Count ?? 0}";
        }
       

    }
}
