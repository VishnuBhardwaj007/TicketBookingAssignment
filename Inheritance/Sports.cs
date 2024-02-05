using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Sports:EventI
    {
        string sportName;
        string teamsName;

        public Sports(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
                     int totalSeats, int availableSeats, decimal ticketPrice, Event_Type eventType,
                     string sportName, string teamsName) : base(eventName, eventDate, eventTime, venueName,
                                                                totalSeats, availableSeats, ticketPrice, eventType)
        {
            this.sportName = sportName;
            this.teamsName = teamsName;
        }

        //Getter and Setter Methods:
        public string SportName
        {
            get { return sportName; }
            set { sportName = value; }
        }

        public string TeamsName
        {
            get { return teamsName; }
            set { teamsName = value; }
        }

        public void DisplaySportDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price: {TicketPrice:C}");
            Console.WriteLine($"Sport: {SportName}");
            Console.WriteLine($"Teams: {TeamsName}");
        }
    }
}   
