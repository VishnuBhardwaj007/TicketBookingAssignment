using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class BookingSystem
    {
        public abstract Event1 CreateEvent(string eventName, string date, string time, int totalSeats,
                                         decimal ticketPrice, string eventType, string venueName);

        public abstract void DisplayEventDetail(Event1 selectedEvent);

        public abstract void BookTicket(Event1 selectedEvent, int numTickets);

        public  abstract void CancelTicket(Event1 selectedEvent,int numTickets);

        public abstract void GetAvailableTickets(Event1 selectedEvent);
       

    }
}
