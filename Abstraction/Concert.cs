using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Concert:Event
    {
        string artist;
        ConcertType type;
        public enum ConcertType
        {
            Theatrical,
            Classical,
            Rock,
            Recital
        }

        // Constructor
        public Concert(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
                       int totalSeats, int availableSeats, decimal ticketPrice,
                       string artist, ConcertType type,Event_Type eventType)
            : base(eventName, eventDate, eventTime, venueName, totalSeats, availableSeats, ticketPrice,eventType)
        {
            this.artist = artist;
            this.type = type;
            
        }

        public override void DisplayEventDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Event Type:{Event_Type.Concert}");

            Console.WriteLine($"Artist: {artist}");
            Console.WriteLine($"Type: {type}");
            
        }
    }
}
