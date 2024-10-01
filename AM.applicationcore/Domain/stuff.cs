using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationcore.Domain
{
    public class stuff : Passenger
    {
        public string Function { get; set; }
        public DateTime EmployementDate { get; set; }
        public float Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + "\n" +  // Calling the base class (Passenger) ToString method
                   $"Function: {Function}\n" +
                   $"Employment Date: {EmployementDate.ToShortDateString()}\n" +
                   $"Salary: {Salary:C}"; // ":C" formats the salary as currency
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("and I'm a staff member");
        }
    }

}
