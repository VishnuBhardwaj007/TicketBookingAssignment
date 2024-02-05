using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_11DatabaseConnectivity.Model;

namespace Task_11DatabaseConnectivity.Repository
{
    internal interface IBookingSystemRepository
    {
        public bool CreateEvent(Event @event);

        public List<Event> GetEventDetails(int eventId);
        public int GetAvailableNoOfTickets(int eventId);
        public decimal CalculateBookingCost(int eventId,int numTickets);
        public bool BookTickets(int customerId, int eventId, int numTickets, decimal totalCost, DateTime bookingDate);

        public bool CancelBooking(int bookingId);
        public List<Booking> GetBookingDetails(int bookingId);


        }
    }

