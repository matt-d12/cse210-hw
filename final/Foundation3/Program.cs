using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        //Create addresses
        Address a1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address a2 = new Address("123 Not Main St", "Toronto", "ON", "Canada");
        Address a3 = new Address("50 W. North Temple Street", "Salt Lake City", "UT", "USA");

        //Create events (1 of each to test)
        Lecture lecture = new Lecture("C# Workshop", "Learn advanced C# topics", "Dec 5, 2025", "2:00 PM", a1, "Dr. Smith", 100);
        Reception reception = new Reception("Networking Night", "Meet professionals in tech", "Dec 10, 2025", "6:00 PM", a2, "rsvp@techmeet.com");
        OutdoorGathering outdoor = new OutdoorGathering("Beach Cleanup", "Join us to keep the beach clean", "Dec 15, 2025", "9:00 AM", a3, "Sunny, 75°F");

        //Create and store in list
        List<Event> events = new List<Event> { lecture, reception, outdoor };

        //Loop through and display based on the event type
        foreach (Event e in events)
        {
            //Show standard details
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            //Show Full details
            Console.WriteLine("Full Details:");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            //Show short description
            Console.WriteLine("Short Desctiption:");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
        }
    }
}