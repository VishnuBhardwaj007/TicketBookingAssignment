using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_7.Model.Event;
using Task_7.Model;

namespace Task_7.Sub_Classes
{
    internal class Sports:Event
    {
        private string sportName;
        private string teamsName;

        
        public Sports(string eventName, DateTime eventDate, TimeSpan eventTime, Venue venue, int totalSeats, decimal ticketPrice, string sportName, string teamsName)
            : base(eventName, eventDate, eventTime, venue, totalSeats, ticketPrice, EventType.Sports)
        {
            this.sportName = sportName;
            this.teamsName = teamsName;
        }

        public override void DisplayEventDetails()
        {
           
            Console.WriteLine($"Sport: {sportName}");
            Console.WriteLine($"Teams: {teamsName}");
        }
    }
}
