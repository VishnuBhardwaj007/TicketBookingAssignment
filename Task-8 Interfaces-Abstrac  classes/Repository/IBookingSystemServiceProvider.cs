using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8_Interfaces_Abstrac__classes.Model;

namespace Task_8_Interfaces_Abstrac__classes.Repository
{
    internal interface IBookingSystemServiceProvider
    {
        void BookTickets(string eventName, int numTickets, Customer[] arrayOfCustomers);
        decimal CalculateBookingCost(int numTickets);

        void CancelBooking(int bookingId);

        Booking GetBookingDetails(int bookingId);
    }
}
