using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8_Interfaces_Abstrac__classes.Model;

namespace Task_8_Interfaces_Abstrac__classes.Repository
{
    internal interface IEventServiceProvider
    {
        Event CreateEvent(string eventName, string date, string time, int totalSeats, decimal ticketPrice, string eventType, Venue venue);
        Event[] GetEventDetails();
        
        int  GetAvailableNoOfTickets(string name);

    }
}
