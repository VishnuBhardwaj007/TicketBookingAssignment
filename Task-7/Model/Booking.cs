using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Model
{
    internal class Booking
    {
        private static int bookingIdCounter = 1; // Counter for generating unique booking IDs

        // Attributes
        public int BookingId { get; private set; }
        public Customer[] Customers { get; set; }
        public Event BookedEvent { get; set; }
        public int NumTickets { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime BookingDate { get; set; }

        // Constructors
        public Booking()
        {
            // Default constructor
            BookingId = GenerateBookingId();
        }

        public Booking(Customer[] customers, Event bookedEvent, int numTickets, decimal totalCost, DateTime bookingDate)
        {
            // Overloaded constructor with customer attributes
            BookingId = GenerateBookingId();
            Customers = customers;
            BookedEvent = bookedEvent;
            NumTickets = numTickets;
            TotalCost = totalCost;
            BookingDate = bookingDate;
        }

        // Method to generate a unique booking ID
        private int GenerateBookingId()
        {
            return bookingIdCounter++;
        }

        // Method to display booking details
        public void DisplayBookingDetails()
        {
            Console.WriteLine($"Booking ID: {BookingId}");
            Console.WriteLine("Customers:");
            foreach (var customer in Customers)
            {
                Console.WriteLine($"- {customer.CustomerName}");
            }
            Console.WriteLine($"Event: {BookedEvent.EventName}");
            Console.WriteLine($"Number of Tickets: {NumTickets}");
            Console.WriteLine($"Total Cost: {TotalCost:C}");
            Console.WriteLine($"Booking Date: {BookingDate}");
        }
    }
}
