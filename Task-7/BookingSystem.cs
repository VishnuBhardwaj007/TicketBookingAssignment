using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_7.Model;

namespace Task_7
{
    internal class BookingSystem
    {
        private List<Event1> events;
        private List<Customer> customers;
        private List<Booking> bookings;

        // Constructor
        public BookingSystem()
        {
            events = new List<Event1>();
            customers = new List<Customer>();
            bookings = new List<Booking>();
        }

        // Method to create a new event and return the event object
        public Event1 CreateEvent(string eventName, DateTime date, TimeSpan time, Venue venue, int totalSeats, decimal ticketPrice, Event1.EventType eventType)
        {
            Event1 newEvent = new Event1(eventName, date, time, venue, totalSeats, ticketPrice, eventType);
            events.Add(newEvent);
            return newEvent;
        }

        public void CalculateBookingCost(Event1 event1, int numTickets)
        {
            decimal totalCost = event1.TicketPrice * numTickets;
 
            Console.WriteLine($"Total cost of booking: {totalCost:C}");
        }


        public void BookTickets(Event1 event1, int numTickets, List<Customer> arrayOfCustomer)
        {
            if (numTickets <= event1.AvailableSeats)
            {
                for (int i = 0; i < numTickets; i++)
                {
                   
                    Customer customer = arrayOfCustomer[i % arrayOfCustomer.Count];

                   
                    event1.BookTickets(1);

                   
                    Booking booking = new Booking
                    {
                        BookingId = bookings.Count + 1, 
                        Customer = customer,
                        Event = event1,
                        NumTickets = 1, 
                        TotalCost = event1.TicketPrice, 
                        BookingDate = DateTime.Now 
                    };

                   
                    bookings.Add(booking);

                    
                    Console.WriteLine($"Ticket booked for customer {customer.CustomerName} for event {event1.EventName}");
                }
            }
            else
            {
                Console.WriteLine($"Sorry, only {event1.AvailableSeats} ticket(s) are available.");
            }
        }

        public bool CancelBooking(int bookingId)
        {
            try
            {
                Event1 event1 = new Event1();
                
                Booking bookingToRemove = bookings.FirstOrDefault(b => b.BookingId == bookingId);

                if (bookingToRemove != null)
                {
                    
                    bookingToRemove.event1.CancelBooking(bookingToRemove.NumTickets);

                    
                    bookings.Remove(bookingToRemove);

                    Console.WriteLine($"Booking ID {bookingId} canceled successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Booking ID {bookingId} not found.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error canceling booking: {ex.Message}");
                return false;
            }
        }

        public int GetAvailableNoOfTickets(Event1 event1)
        {
            return event1.AvailableSeats;
        }

        public void GetEventDetails(Event1 event1)
        {
            
            event1.DisplayEventDetail();
        }
    }
}
