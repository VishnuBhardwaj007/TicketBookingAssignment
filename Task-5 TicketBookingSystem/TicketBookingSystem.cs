using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_TicketBookingSystem
{
    internal class TicketBookingSystem
    {
        private const int MaxEvents = 100; 
        private Event[] events = new Event[MaxEvents];
        private int eventCount = 0;

        public Event CreateEvent(string eventName, string date, string time, int totalSeats, decimal ticketPrice, string eventType, string venueName)
        {
            if (eventCount < MaxEvents)
            {
                Event.Event_Type eventTypeEnum = GetEventTypeEnum(eventType);

                Event newEvent = new Event(eventName, DateTime.Parse(date), TimeSpan.Parse(time), venueName, totalSeats, totalSeats, ticketPrice, eventTypeEnum);
                events[eventCount++] = newEvent;

                return newEvent;
            }
            else
            {
                Console.WriteLine("Maximum number of events reached. Cannot create more events.");
                return null;
            }
        }

        public Event.Event_Type GetEventTypeEnum(string eventType)
        {
            switch (eventType.ToLower())
            {
                case "movie":
                    return Event.Event_Type.Movie;
                case "sport":
                    return Event.Event_Type.Sports;
                case "concert":
                    return Event.Event_Type.Concert;
                default:
                    Console.WriteLine("Invalid Typr");
                    return 0;
            }
        }

        // Methods::

        public void DisplayEventDetails(Event eventToDisplay)
        {
            if (eventToDisplay != null)
            {
                eventToDisplay.DisplayEventDetails();
            }
            else
            {
                Console.WriteLine("Event not found or is null.");
            };


        //    Public void CancelTickets(Event eventToCancel, int numTickets)
        //    {
        //        if (eventToCancel != null)
        //        {
        //            // Cancel specified number of tickets for the event
        //            eventToCancel.CancelBooking(numTickets);
        //            Console.WriteLine($"Cancellation successful! {numTickets} tickets canceled.");
        //        }
        //        else
        //        {
        //            // Display a message if the event is not found or is null
        //            Console.WriteLine("Event not found or is null. Cancellation failed.");
        //        }
        //    }
        }

         public  decimal BookTickets(Event eventToBook, int numTickets)
        {
            if (eventToBook != null)
            {
                // Check if there are enough available seats
                if (numTickets <= eventToBook.AvailableSeats)
                {
                    eventToBook.BookTickets(numTickets);

                    // Calculate and return the total cost of the booking
                    decimal totalCost = numTickets * eventToBook.TicketPrice;
                    Console.WriteLine($"Booking successful! Total Cost: {totalCost:C}");
                    return totalCost;
                }
                else
                {
                    // Display a message if seats are not available
                    Console.WriteLine("Sorry, not enough available seats for the requested number of tickets.");
                    return 0;
                }
            }
            else
            {
                // Display a message if the event is not found or is null
                Console.WriteLine("Event not found or is null.");
                return 0;
            }
        }
    }
}
