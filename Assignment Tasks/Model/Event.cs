using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Assignment_Tasks.Model.Event;

namespace Assignment_Tasks.Model
{
    internal class Event
    {
        

        string event_name;
        DateTime event_date;
        TimeSpan event_time;
        string venue_name;
        int total_seats;
        int available_seats;
        decimal ticket_price;
        Event_Type event_type;

        public enum Event_Type
        {
            Movie,
            Sports,
            Concert
        }

        //Overloading Constructor:
        public Event(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName,
                 int totalSeats, int availableSeats, decimal ticketPrice, Event_Type eventType)
        {
            event_name = eventName;
            event_date = eventDate;
            event_time = eventTime;
            venue_name = venueName;
            total_seats = totalSeats;
            available_seats = availableSeats;
            ticket_price = ticketPrice;
            event_type = eventType;

        }

        //Getters and Setters:
        public string EventName   // property
        {
            get { return event_name; }   // get method
            set { event_name = value; }  // set method
        }
        public DateTime EventDate   // property
        {
            get { return event_date; }   // get method
            set { event_date = value; }  // set method
        }
        public TimeSpan EventTime  // property
        {
            get { return event_time; }   // get method
            set { event_time = value; }  // set method
        }
        public string VenueName   // property
        {
            get { return venue_name; }   // get method
            set { venue_name = value; }  // set method
        }
        public int  TotalSeats  // property
        {
            get { return total_seats; }   // get method
            set { total_seats = value; }  // set method
        }
        public int AvailableSeats   // property
        {
            get { return available_seats; }   // get method
            set { available_seats = value; }  // set method
        }
        public decimal TicketPrice   // property
        {
            get { return ticket_price; }   // get method
            set { ticket_price = value; }  // set method
        }

        public Event_Type EventType
        {
            get { return event_type; }
            set { event_type = value; }
        }

        public object EventTypeType { get; internal set; }

        //Creating a Function To Calculate Total Revenue:
        public decimal Calculate_Total_Revenue()
        {
            int numTicketsSold = TotalSeats - AvailableSeats;
            return numTicketsSold * TicketPrice;
        }

        //To get Total Number of tickets Booked:
        public int getBookedNoOfTickets()
        {
            return TotalSeats - AvailableSeats;
        }

        public void BookTickets(int numTickets)
        {
            if (numTickets <= available_seats)
            {
                available_seats -= numTickets;
                Console.WriteLine($"Your {numTickets} Booked Successfully! Enjoy The Show... ");
            }

            else
            {
                Console.WriteLine($"Sorry, Only {available_seats} Tickets are Available");
            }
        }

        //To Cancel Tickets and To Update Avaialable Seats:
        public void CancelBooking(int numTickets)
        {
            available_seats += numTickets;
            Console.WriteLine($"Your {numTickets} ticket Canceled");
        }

        //To Display Event Details Like: Event Name , Event Date and Time, Event Seat Availability and Price:
        public void DisplayEventDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
        }




    }
}
