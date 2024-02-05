using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Model
{
    internal class Event1
    {

        private string eventName;
        private DateTime eventDate;
        private TimeSpan eventTime;
        private Venue venue;
        private int totalSeats;
        private int availableSeats;
        private decimal ticketPrice;
        private EventType eventType;
        private DateTime date;
        private TimeSpan time;
        private int totalSeats1;
        private int totalSeats2;
        private string eventType1;

        // Enumeration for Event Type
        public enum EventType
        {
            Movie,
            Sports,
            Concert
        }

        // Constructors
        public Event1()
        {
            // Default constructor
        }

        public Event1(string eventName, DateTime eventDate, TimeSpan eventTime, Venue venue, int totalSeats, decimal ticketPrice, EventType eventType)
        {
            this.eventName = eventName;
            this.eventDate = eventDate;
            this.eventTime = eventTime;
            this.venue = venue;
            this.totalSeats = totalSeats;
            this.availableSeats = totalSeats; // Initially available seats are equal to total seats
            this.ticketPrice = ticketPrice;
            this.eventType = eventType;
        }

        public Event1(string eventName, DateTime date, TimeSpan time, Venue venue, int totalSeats1, int totalSeats2, decimal ticketPrice, string eventType1)
        {
            this.eventName = eventName;
            this.date = date;
            this.time = time;
            this.venue = venue;
            this.totalSeats1 = totalSeats1;
            this.totalSeats2 = totalSeats2;
            this.ticketPrice = ticketPrice;
            this.eventType1 = eventType1;
        }

        // Getter and Setter for Event Name
        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

        // Getter and Setter for Event Date
        public DateTime EventDate
        {
            get { return eventDate; }
            set { eventDate = value; }
        }

        // Getter and Setter for Event Time
        public TimeSpan EventTime
        {
            get { return eventTime; }
            set { eventTime = value; }
        }

        // Getter and Setter for Venue
        public Venue Venue
        {
            get { return venue; }
            set { venue = value; }
        }

        // Getter and Setter for Total Seats
        public int TotalSeats
        {
            get { return totalSeats; }
            set { totalSeats = value; }
        }

        // Getter for Available Seats
        public int AvailableSeats
        {
            get { return availableSeats; }
        }

        // Getter and Setter for Ticket Price
        public decimal TicketPrice
        {
            get { return ticketPrice; }
            set { ticketPrice = value; }
        }

        // Getter and Setter for Event Type
        public EventType EventTypeValue
        {
            get { return eventType; }
            set { eventType = value; }
        }

        // Method to calculate total revenue
        public decimal CalculateTotalRevenue()
        {
            int numTicketsSold = TotalSeats - AvailableSeats;
            return numTicketsSold * TicketPrice;
        }

        // Method to get total booked tickets
        public int GetBookedNoOfTickets()
        {
            return TotalSeats - AvailableSeats;
        }

        // Method to book tickets
        public void BookTickets(int numTickets)
        {
            if (numTickets <= availableSeats)
            {
                availableSeats -= numTickets;
                Console.WriteLine($"Your {numTickets} ticket(s) booked successfully! Enjoy the event...");
            }
            else
            {
                Console.WriteLine($"Sorry, only {availableSeats} ticket(s) are available.");
            }
        }

        // Method to cancel booking
        public void CancelBooking(int numTickets)
        {
            availableSeats += numTickets;
            Console.WriteLine($"Your {numTickets} ticket(s) canceled.");
        }

        // Method to display event details

        public void DisplayEventDetail()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Venue: {Venue.VenueName}, Address: {Venue.Address}");
            Console.WriteLine($"Total Seats: {TotalSeats}, Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price: {TicketPrice:C}");
            Console.WriteLine($"Event Type: {EventTypeValue}");
        }
    }

}

