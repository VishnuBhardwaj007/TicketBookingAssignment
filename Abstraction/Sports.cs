using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstraction.Movie;

namespace Abstraction
{
    internal class Sports:Event
    {
        string sportName;
        string teamsName;

        // Constructor
        public Sports(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
                     int totalSeats, int availableSeats, decimal ticketPrice,
                     string sportName, string teamsName,Event_Type eventType)
            : base(eventName, eventDate, eventTime, venueName, totalSeats, availableSeats, ticketPrice,eventType)
        {
            this.sportName = sportName;
            this.teamsName = teamsName;
            
        }

        public override void DisplayEventDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price:{TicketPrice}");
            Console.WriteLine($"Event Type :{Event_Type.Sports}");
          
        }
    }
}
