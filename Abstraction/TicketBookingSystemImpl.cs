using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class TicketBookingSystemImpl : BookingSystem
    {
        public override void BookTicket(Event1 selectedEvent, int numTickets)
        {
            selectedEvent.DisplayEventDetails();
        }

        public override void CancelTicket(Event1 selectedEvent, int numTickets)
        {
            selectedEvent.CancelBooking(numTickets);
        }

        public override Event1 CreateEvent(string eventName, string date, string time, int totalSeats, decimal ticketPrice, string eventType, string venueName)
        {
            List<Event1> events = new List<Event1>();
            DateTime eventDate = DateTime.Parse(date);
            TimeSpan eventTime = TimeSpan.Parse(time);
            Event1 newEvent = new Event1(eventName, eventDate, eventTime, venueName, totalSeats, totalSeats, ticketPrice, Event1.Event_Type.Movie);
            events.Add(newEvent);
            return newEvent;
        }

        public override void DisplayEventDetail(Event1 selectedEvent)
        {
            selectedEvent.DisplayEventDetails();
        }

        public override void GetAvailableTickets(Event1 selectedEvent)
        {
            Console.WriteLine(selectedEvent.AvailableSeats);
        }
    }
}
