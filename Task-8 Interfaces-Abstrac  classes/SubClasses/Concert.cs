using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8_Interfaces_Abstrac__classes.Model;

namespace Task_8_Interfaces_Abstrac__classes.SubClasses
{
    internal class Concert:Event
    {
        private string artist;
        private string type;

        public enum ConcertType
        {
            Theatrical,
            Classical,
            Rock,
            Recital
        }



        // Overloaded Constructor with Customer attributes
        public Concert(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
                       int totalSeats, int availableSeats, decimal ticketPrice, Event_Type eventType, string artist, string type)
            : base(eventName, eventDate, eventTime, venueName, totalSeats, availableSeats, ticketPrice, eventType)

        {
            this.artist = artist;
            this.type = type;
        }

        // Getter and Setter for Artist
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        // Getter and Setter for Type
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        // Method to display concert details, including the artist
        public void DisplayConcertDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price: {TicketPrice}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Type: {Type}");
        }
    }
}
