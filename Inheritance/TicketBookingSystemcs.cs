using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TicketBookingSystemcs
    {
        public EventI CreateEvent(string eventName, string date, string time, int totalSeats, decimal ticketPrice, string eventType, string venueName)
        {
            
            List<EventI> events = new List<EventI>();
            DateTime eventDate = DateTime.Parse(date);
            TimeSpan eventTime = TimeSpan.Parse(time);
            EventI newEvent = new EventI(eventName, eventDate, eventTime, venueName, totalSeats, totalSeats, ticketPrice, EventI.Event_Type.Movie);
            events.Add(newEvent);
            return newEvent;
        }

        
            public void DisplayEventDetail(EventI eventObject)
            {
             eventObject.DisplayEventDetails();
      
            }
        public void BookTicket(EventI eventObject,int numTickets)
        {
            
                eventObject.BookTickets(numTickets);
            
        }

        public void CancelTickets(EventI eventObject,int numTickets) 
        {
            eventObject.CancelBooking(numTickets);
        }




        }
        
 }


