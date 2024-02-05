using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11DatabaseConnectivity.TicketBookingSystemService
{
    internal interface ITicketBookingSystemService
    {
        public void CreateEvent();
        public void GetEventDetails();
        public void AvailableNoOfTickets();
        public void CalculateBookingCost();
        public void BookTicket();
        public void CancelBooking();
        public void GetBookingDetails();
    }
}
