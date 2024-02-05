using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8_Interfaces_Abstrac__classes.Model;
using Task_8_Interfaces_Abstrac__classes.Repository;

namespace Task_8_Interfaces_Abstrac__classes.Services
{
    internal class AppServices
    {
        EventServiceProviderImpl eventServiceProviderImpl = new EventServiceProviderImpl();
        public void EventCreate()
        {
           
            Console.WriteLine("Enter event details:");
            Console.Write("Event Name: ");
            string eventName = Console.ReadLine();
            Console.Write("Date: ");
            string date = Console.ReadLine();
            Console.Write("Time: ");
            string time = Console.ReadLine();
            Console.Write("Total Seats: ");
            int totalSeats = int.Parse(Console.ReadLine());
            Console.Write("Ticket Price: ");
            decimal ticketPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Event Type: ");
            string eventType = Console.ReadLine();
            Console.Write("Venue: ");
            string venueName = Console.ReadLine();

            Venue venue = new Venue(venueName);
            Event createdEvent =eventServiceProviderImpl.CreateEvent(eventName, date, time, totalSeats, ticketPrice, eventType, venue);

            if (createdEvent != null)
            {
                Console.WriteLine("Event created successfully.");
            }
            else
            {
                Console.WriteLine("Event creation failed.");
            }
            
        }

        public void SeatsAvailable()
        {
            try
            {
                Console.WriteLine("Enter event name:");
                string eventNameToCheck = Console.ReadLine();
                int availableTickets = eventServiceProviderImpl.GetAvailableNoOfTickets(eventNameToCheck);
                Console.WriteLine($"Available Tickets: {availableTickets}");
            }
            catch ( Exception e ) 
            { Console.WriteLine(e.Message); }
            

        }

        public void EventDetails()
        {
            Console.WriteLine("Event Details:");
            Event[] events = eventServiceProviderImpl.GetEventDetails();

            foreach (Event ev in events)
            {
                Console.WriteLine($"Event: {ev.EventName}, Date: {ev.EventDate}, Time: {ev.EventTime}, Seats: {ev.TotalSeats}, Price: {ev.TicketPrice}, Type: {ev.EventType}, Venue: {ev.VenueName}");
            }
        }
    }
}
