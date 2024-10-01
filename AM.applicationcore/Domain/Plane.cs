using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationcore.Domain
{
     public enum PlaneType
    {
        Airbus,boing
    }

    public class Plane
    {
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Capacity { get; set; }
        public virtual List<Flight> Flights { get; set; }
        public Plane() { }  // Parameterless constructor

        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }
        public override string ToString()
        {
            return $"Plane Info: \n" +
                   $"Type: {PlaneType}\n" +
                   $"Manufacture Date: {ManufactureDate.ToShortDateString()}\n" +
                   $"Capacity: {Capacity} passengers\n" +
                   $"Number of Flights: {Flights?.Count ?? 0}";
        }
    }

}
