using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_7.Model;

namespace Task_7.BookingSystemService
{
    internal class BookingSystemImpl:IBookingSystem
    {
        BookingSystem bookingSystem=new BookingSystem();

        public void BookTickets()
        {
            throw new NotImplementedException();
        }

        public void CalculateBookingCost()
        {
            throw new NotImplementedException();
        }

        public void CancelBooking()
        {
            throw new NotImplementedException();
        }

        public void CreateEvent()
        {
            Console.WriteLine("Enter details for the new event:");

            Console.Write("Event Name: ");
            string eventName = Console.ReadLine();

            Console.Write("Event Date (MM/dd/yyyy): ");
            DateTime eventDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Event Time (HH:mm): ");
            TimeSpan eventTime = TimeSpan.Parse(Console.ReadLine());

            Console.Write("Venue Name: ");
            string venueName = Console.ReadLine();

            Console.Write("Total Seats: ");
            int totalSeats = int.Parse(Console.ReadLine());

            Console.Write("Ticket Price: ");
            decimal ticketPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Event Type (Movie/Sports/Concert): ");
            Event1.EventType eventType = (Event1.EventType)Enum.Parse(typeof(Event1.EventType), Console.ReadLine(), true);

            // Assume you have a venue object (you need to create one or get it from somewhere)
            Venue venue = new Venue(1, venueName, "Venue Address");

            // Create the event and check if it was successful
            Event1 newEvent = bookingSystem.CreateEvent(eventName, eventDate, eventTime, venue, totalSeats, ticketPrice, eventType);

            if (newEvent != null)
            {
                Console.WriteLine($"Event '{newEvent.EventName}' created successfully!");
            }
            else
            {
                Console.WriteLine("Failed to create the event.");
            }
        }

        public void GetAvailableNoOfTickets()
        {
            throw new NotImplementedException();
        }

        public void GetEventDetails()
        {
            throw new NotImplementedException();
        }
    }
}
