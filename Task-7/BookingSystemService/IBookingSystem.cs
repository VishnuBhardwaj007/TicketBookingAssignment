using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.BookingSystemService
{
    internal interface IBookingSystem
    {
        public void  CreateEvent();

        public void CalculateBookingCost();
        public void GetEventDetails();
        public void BookTickets();

        public void CancelBooking();

        public void GetAvailableNoOfTickets();

    }
}
