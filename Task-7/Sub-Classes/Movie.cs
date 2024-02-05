using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_7.Model.Event;
using Task_7.Model;

namespace Task_7.Sub_Classes
{
    internal class Movie:Event
    {
        private MovieGenre genre;
        private string actorName;
        private string actressName;

        // Enumeration for Movie Genre
        public enum MovieGenre
        {
            Action,
            Comedy,
            Horror
        }

        // Constructors
        public Movie(string eventName, DateTime eventDate, TimeSpan eventTime, Venue venue, int totalSeats, decimal ticketPrice, MovieGenre genre, string actorName, string actressName)
            : base(eventName, eventDate, eventTime, venue, totalSeats, ticketPrice, EventType.Movie)
        {
            this.genre = genre;
            this.actorName = actorName;
            this.actressName = actressName;
        }
        public override void DisplayEventDetails()
        {
            
            Console.WriteLine($"Movie Genre: {genre}");
            Console.WriteLine($"Lead Actor: {actorName}");
            Console.WriteLine($"Lead Actress: {actressName}");
        }

    }
}
