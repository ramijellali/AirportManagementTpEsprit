using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationcore.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Flight> Flights { get; set; }

        public Passenger() { }

        public Passenger(string FName,string LName,string Email)
        {
            FName = FName;
            LName = LName;
            Email = Email;
        }
        public override string ToString()
        {
            return $"Passenger Info: \n" +
                   $"Name: {FirstName} {LastName}\n" +
                   $"Passport Number: {PassportNumber}\n" +
                   $"Birth Date: {BirthDate.ToShortDateString()}\n" +
                   $"Phone Number: {TelNumber}\n" +
                   $"Email: {EmailAddress}\n" +
                   $"Number of Flights: {Flights?.Count ?? 0}";
        }
        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }
        public bool checkprofile(string firstName, string lastName, string email)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress == email;
        }
        public bool CheckProfile(string firstName, string lastName, string email = null)
        {
            if (email != null)
                return FirstName == firstName && LastName == lastName &&
               EmailAddress == email;
            else
                return FirstName == firstName && LastName == lastName;
        }
        
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        
        }

    }
}
