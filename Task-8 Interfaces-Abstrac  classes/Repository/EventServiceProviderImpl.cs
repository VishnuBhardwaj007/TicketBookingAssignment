using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8_Interfaces_Abstrac__classes.Model;

namespace Task_8_Interfaces_Abstrac__classes.Repository
{
    internal class EventServiceProviderImpl : IEventServiceProvider
    {
        private const int MaxEvents = 100; 
        private Event[] eventsList = new Event[MaxEvents];
        private int eventCount = 0;
        
        public Event CreateEvent(string eventName, string date, string time, int totalSeats, decimal ticketPrice, string eventType, Venue venu)
        {
            if (eventCount < MaxEvents)
            {
                Event eventObject = new Event(eventName, DateTime.Parse(date), TimeSpan.Parse(time), totalSeats, ticketPrice, eventType, venu.venueName);
                eventsList[eventCount++] = eventObject;
                
                return eventObject;
            }
            else
            {
                Console.WriteLine("Maximum number of events reached. Cannot create more events.");
                return null;
            }
        }



        public int GetAvailableNoOfTickets(string eventName)
        {
            Event eventObject = eventsList.FirstOrDefault(ev => ev.EventName == eventName);

            if (eventObject != null)
            {
                return eventObject.AvailableSeats;
            }
            else
            {
                Console.WriteLine($"Event with name '{eventName}' not found.");
                return -1;
            }



        }
           
          


        

        public Event[] GetEventDetails()
        {
            Event[] availableEvents = new Event[eventCount];
            Array.Copy(eventsList, availableEvents, eventCount);

            return availableEvents;


        }

       

    }
}
