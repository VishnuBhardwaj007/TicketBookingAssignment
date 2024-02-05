using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_7.Model.Event;
using Task_7.Model;

namespace Task_7.Sub_Classes
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

       
        public Concert(string eventName, DateTime eventDate, TimeSpan eventTime, Venue venue, int totalSeats, decimal ticketPrice, string artist, string type)
            : base(eventName, eventDate, eventTime, venue, totalSeats, ticketPrice, EventType.Concert)
        {
            this.artist = artist;
            this.type = type;
        }

        public override void DisplayEventDetails()
        {
          
            Console.WriteLine($"Artist: {artist}");
            Console.WriteLine($"Concert Type: {type}");
        }
    }
}
