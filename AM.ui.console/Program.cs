// See https://aka.ms/new-console-template for more information
using AM.applicationcore.Domain;
using AM.applicationcore.Services;
using AM.ApplicationCore.Domain;
using System.ComponentModel.DataAnnotations;  // Importing the namespace so you don't have to fully qualify each type



Plane plane = new Plane();  // No need for "AM.applicationcore.Domain."
plane.PlaneType = PlaneType.Airbus;
plane.Capacity = 200;
plane.ManufactureDate = new DateTime(2018, 11, 10);

Plane plane2 = new Plane(PlaneType.boing, 300, DateTime.Now);  // Directly using "Plane" and "PlaneType"
// Create instances of Passenger, Traveller, and Staff
Passenger passenger = new Passenger("hamza", "jellali", "hamza@esprit.tn");
Traveller traveller = new Traveller
{
    FirstName = "rami",
    LastName = "jellali",
    EmailAddress = "rami@esprit.tn",
    HealthInformation = "None",
    Nationality = "Tunisian"
};
stuff staff = new stuff
{
    FirstName = "donia",
    LastName = "benothmen",
    EmailAddress = "donia@esprit.tn",
    Function = "Pilot",
    EmployementDate = DateTime.Now.AddYears(-5),
    Salary = 50000
};

// Test the PassengerType method for each instance
passenger.PassengerType();  // Output: "I am a Passenger"
traveller.PassengerType();   // Output: "I am a Passenger and I'm a traveller"
staff.PassengerType();       // Output: "I am a Passenger and I'm a staff member"

ServiceFlight serviceFlight = new ServiceFlight()
{
    Flights = TestData.listFlights
};

Console.WriteLine(" // Get flight dates for a specific destination\r\n");

// Get flight dates for a specific destination
var flightDates = serviceFlight.GetFlightDates("Paris"); // Adjust the destination as needed
Console.WriteLine("Flight Dates for Paris:");
foreach (var date in flightDates)
{
    Console.WriteLine(date);
}

Console.WriteLine(" // Get flight dates and destination for a specific plane");
var flightdetails = serviceFlight.ShowFlightDetails(plane2);
Console.WriteLine("Daates and destinations of the plane2");
flightdetails.ForEach(f => Console.WriteLine(f));

Console.WriteLine(" Get avg  duration for a specific destination");
var flightduration = serviceFlight.DurationAverage("Paris");
Console.WriteLine(flightduration+"seconds");

Console.WriteLine(" ordered via duration");
var ordered = serviceFlight.OrderedDurationFlights();
foreach (var flight in ordered)
{
    Console.WriteLine($"Destination: {flight.Destination}, Estimated Duration: {flight.EstimatedDuration}");
}
