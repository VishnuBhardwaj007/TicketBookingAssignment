using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11DatabaseConnectivity.Model
{
    internal class Event
    {

        public int eventId;
        public string eventName;
        public DateTime eventDate;
        public TimeSpan eventTime;
        public string venueName;
        public int totalSeats;
        public int availableSeats;
        public decimal ticketPrice;
        public Event_Type eventType;
        private Event_Type event_Type;
        private Event_Type eventType1;

        public enum Event_Type
        {
            Movie,
            Sports,
            Concert
        }

        //Overloading Constructor:
        public Event(int Id,string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
                 int totalSeats, int availableSeats, decimal ticketPrice, Event_Type eventType)
        {
            eventId = Id;
            this.eventName = eventName;
            this.eventDate = eventDate;
            this.eventTime = eventTime;
            this.venueName = venueName;
            this.totalSeats = totalSeats;
            this.availableSeats = availableSeats;
            this.ticketPrice = ticketPrice;
            this.eventType = eventType;

        }

        public Event(string? eventName, DateTime eventDate, TimeSpan eventTime, string? venueName, int totalSeats, int availableSeats, decimal ticketPrice, Event_Type event_Type, int eventId, Event_Type eventType)
        {
            this.eventName = eventName;
            this.eventDate = eventDate;
            this.eventTime = eventTime;
            this.venueName = venueName;
            this.totalSeats = totalSeats;
            this.availableSeats = availableSeats;
            this.ticketPrice = ticketPrice;
            this.event_Type = event_Type;
        }

        //public Event(int eventId, string? eventName, DateTime eventDate, TimeSpan eventTime, string? venueName, int totalSeats, int availableSeats, decimal ticketPrice, Event_Type eventType)
        //{
        //    this.eventId = eventId;
        //    this.eventName = eventName;
        //    this.eventDate = eventDate;
        //    this.eventTime = eventTime;
        //    this.venueName = venueName;
        //    this.totalSeats = totalSeats;
        //    this.availableSeats = availableSeats;
        //    this.ticketPrice = ticketPrice;
        //    eventType1 = eventType;
        //}

        public int EventId
        {
            get { return eventId; }
            set { eventId = value; }
        }

        //Getters and Setters:
        public string EventName   // property
        {
            get { return eventName; }   // get method
            set { eventName = value; }  // set method
        }
        public DateTime EventDate   // property
        {
            get { return eventDate; }   // get method
            set { eventDate = value; }  // set method
        }
        public TimeSpan EventTime  // property
        {
            get { return eventTime; }   // get method
            set { eventTime = value; }  // set method
        }
        public string VenueName   // property
        {
            get { return venueName; }   // get method
            set { venueName = value; }  // set method
        }
        public int TotalSeats  // property
        {
            get { return totalSeats; }   // get method
            set { totalSeats = value; }  // set method
        }
        public int AvailableSeats   // property
        {
            get { return availableSeats; }   // get method
            set { availableSeats = value; }  // set method
        }
        public decimal TicketPrice   // property
        {
            get { return ticketPrice; }   // get method
            set { ticketPrice = value; }  // set method
        }

        public Event_Type EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }

    }
}
