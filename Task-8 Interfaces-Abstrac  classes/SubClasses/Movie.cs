using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8_Interfaces_Abstrac__classes.Model;

namespace Task_8_Interfaces_Abstrac__classes.SubClasses
{
    internal class Movie:Event
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



        // Overloaded Constructor with Customer attributes
        public Movie(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
                     int totalSeats, int availableSeats, decimal ticketPrice, Model.Event.Event_Type eventType,
                     MovieGenre genre, string actorName, string actressName) : base(eventName, eventDate, eventTime, venueName,
                                                                              totalSeats, availableSeats, ticketPrice, eventType)
        {
            this.genre = genre;
            this.actorName = actorName;
            this.actressName = actressName;
        }

        // Getter and Setter for Genre
        public MovieGenre Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        // Getter and Setter for ActorName
        public string ActorName
        {
            get { return actorName; }
            set { actorName = value; }
        }

        // Getter and Setter for ActressName
        public string ActressName
        {
            get { return actressName; }
            set { actressName = value; }
        }

        // Method to display movie details, including genre
        public void DisplayMovieDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price: {TicketPrice}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Actor: {ActorName}");
            Console.WriteLine($"Actress: {ActressName}");
        }
    }
}
