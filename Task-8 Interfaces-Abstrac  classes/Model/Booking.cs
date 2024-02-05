using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Interfaces_Abstrac__classes.Model
{
    internal class Booking
    {
        
        private Event eventObj;
        public int numTickets;
        private decimal bookingCost;
        public Customer[] customer;


        // Constructor
        public Booking(Event eventObj,int numTickets, Customer[] arrayOfCustomers)
        {
            this.eventObj = eventObj;
            this.bookingCost = 0;
            this.numTickets = numTickets;
            this.customer = arrayOfCustomers;
           


        }

        // Calculate and set the total cost of the booking
        public void CalculateBookingCost(int numTickets)
        {
            bookingCost = (int)(numTickets * eventObj.TicketPrice);
            Console.WriteLine($"You total bookingCost::{bookingCost}");
        }

        // Book a specified number of tickets for an event
        public void BookTickets(int numTickets)
        {
            eventObj.BookTickets(numTickets);
            CalculateBookingCost(numTickets);
        }

        // Cancel the booking and update the available seats
        public void CancelBooking(int numTickets)
        {
            eventObj.CancelBooking(numTickets);

        }

        // Return the total available tickets
        public int GetAvailableNoOfTickets()
        {
            return eventObj.AvailableSeats;
        }

        // Return event details from the event class
        public string GetEventDetails()
        {
            return $"Event Details: {eventObj.EventName}, Date: {eventObj.EventDate.ToShortDateString()}, Time: {eventObj.EventTime}, Available Seats: {eventObj.AvailableSeats}, Ticket Price: {eventObj.TicketPrice}";
        }
    }
}
