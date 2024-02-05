using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ServiceTicketBooking
    {
        TicketBookingSystemcs ticketBookingSystem = new TicketBookingSystemcs();
        public void BookTicket()
        {
            EventI eventI = new EventI();
            Console.WriteLine("Enter EventName::");
            eventI.EventName = Console.ReadLine();
            Console.WriteLine("Enter Event Date::");
            eventI.EventDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Time::");
            eventI.EventTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Venue Name::");
            eventI.VenueName = Console.ReadLine();
            Console.WriteLine("Enter Total Seats::");
            eventI.TotalSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Tickets::");
            eventI.AvailableSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticket Price::");
            eventI.TicketPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Type (Movie,Concert,Sports)::");
            eventI.EventTypeType = Console.ReadLine();

            Console.WriteLine("Enter Number of Tickets to Book::");
            int numTickets=int.Parse(Console.ReadLine()) ;

            ticketBookingSystem.BookTicket(eventI, numTickets);
        }


        public void DisplayEventDetail()
        {
            EventI eventI=new EventI();
            Console.WriteLine("Enter EventName::");
            eventI.EventName = Console.ReadLine();
            Console.WriteLine("Enter Event Date::");
            eventI.EventDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Time::");
            eventI.EventTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Venue Name::");
            eventI.VenueName = Console.ReadLine();
            Console.WriteLine("Enter Total Seats::");
            eventI.TotalSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Tickets::");
            eventI.AvailableSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticket Price::");
            eventI.TicketPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Type (Movie,Concert,Sports)::");
            eventI.EventTypeType = Console.ReadLine();

            ticketBookingSystem.DisplayEventDetail(eventI);

        }

        public void CancelTickets()
        {
            EventI eventI = new EventI();
            Console.WriteLine("Enter EventName::");
            eventI.EventName = Console.ReadLine();
            Console.WriteLine("Enter Event Date::");
            eventI.EventDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Time::");
            eventI.EventTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Venue Name::");
            eventI.VenueName = Console.ReadLine();
            Console.WriteLine("Enter Total Seats::");
            eventI.TotalSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Tickets::");
            eventI.AvailableSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticket Price::");
            eventI.TicketPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Type (Movie,Concert,Sports)::");
            eventI.EventTypeType = Console.ReadLine();

            Console.WriteLine("Enter Number of Tickets to Book::");
            int numTickets = int.Parse(Console.ReadLine());

            ticketBookingSystem.CancelTickets(eventI, numTickets);

        }

    }
}
