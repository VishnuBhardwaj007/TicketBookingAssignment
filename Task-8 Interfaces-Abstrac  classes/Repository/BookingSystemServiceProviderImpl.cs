using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8_Interfaces_Abstrac__classes.Model;

namespace Task_8_Interfaces_Abstrac__classes.Repository
{
    internal class BookingSystemServiceProviderImpl : EventServiceProviderImpl, IBookingSystemServiceProvider
    {
        public void BookTickets(string eventName, int numTickets, Customer[] arrayOfCustomers)
        {
            ;
        }

        public decimal CalculateBookingCost(int numTickets)
        {
            throw new NotImplementedException();
        }

        public void CancelBooking(int bookingId)
        {
            throw new NotImplementedException();
        }

        public Booking GetBookingDetails(int bookingId)
        {
            throw new NotImplementedException();
        }
    }
}
