using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstraction.Event;

namespace Abstraction
{
    internal class Movie : Event
    {
        MovieGenre genre;
        string actorName;
        string actressName;

        public enum MovieGenre
        {
            Action,
            Comedy,
            Horror
        }

        // Constructor
        public Movie(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
                     int totalSeats, int availableSeats, decimal ticketPrice,
                     MovieGenre genre, string actorName, string actressName, Event_Type eventType)
            : base(eventName, eventDate, eventTime, venueName, totalSeats, availableSeats, ticketPrice, eventType)
        {
            this.genre = genre;
            this.actorName = actorName;
            this.actressName = actressName;
            
        }

        public override void DisplayEventDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price:{TicketPrice}");
            Console.WriteLine($"Event Type :{Event_Type.Movie}");
            Console.WriteLine($"Event Genre:{MovieGenre.Comedy}");



        }
    }
}
