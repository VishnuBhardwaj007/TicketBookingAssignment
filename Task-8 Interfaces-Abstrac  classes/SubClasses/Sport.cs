using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8_Interfaces_Abstrac__classes.Model;

namespace Task_8_Interfaces_Abstrac__classes.SubClasses
{
    internal class Sport:Event
    {
        string sportName;
        string teamsName;

        public Sport(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
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
