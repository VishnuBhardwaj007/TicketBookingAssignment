using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class SericeTicketbookingSystem
    {
        TicketBookingSystemImpl ticketBookingSystemImpl=new TicketBookingSystemImpl();

        public void BookTicket()
        {
            Event1 event1 = new Event1();
            Console.WriteLine("Enter EventName::");
            event1.EventName = Console.ReadLine();
            Console.WriteLine("Enter Event Date::");
            event1.EventDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Time::");
            event1.EventTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Venue Name::");
            event1.VenueName = Console.ReadLine();
            Console.WriteLine("Enter Total Seats::");
            event1.TotalSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Tickets::");
            event1.AvailableSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticket Price::");
            event1.TicketPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Type (Movie,Concert,Sports)::");
            event1.EventTypeType = Console.ReadLine();

            Console.WriteLine("Enter Number of Tickets to Book::");
            int numTickets = int.Parse(Console.ReadLine());

            ticketBookingSystemImpl.BookTicket(event1, numTickets);
        }


        public void DisplayEventDetail()
        {
            Event1 event1 = new Event1();
            Console.WriteLine("Enter EventName::");
            event1.EventName = Console.ReadLine();
            Console.WriteLine("Enter Event Date::");
            event1.EventDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Time::");
            event1.EventTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Venue Name::");
            event1.VenueName = Console.ReadLine();
            Console.WriteLine("Enter Total Seats::");
            event1.TotalSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Tickets::");
            event1.AvailableSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticket Price::");
            event1.TicketPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Type (Movie,Concert,Sports)::");
            event1.EventTypeType = Console.ReadLine();

            ticketBookingSystemImpl.DisplayEventDetail(event1);

        }

        public void CancelTickets()
        {
            Event1 event1 = new Event1();
            Console.WriteLine("Enter EventName::");
            event1.EventName = Console.ReadLine();
            Console.WriteLine("Enter Event Date::");
            event1.EventDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Time::");
            event1.EventTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Venue Name::");
            event1.VenueName = Console.ReadLine();
            Console.WriteLine("Enter Total Seats::");
            event1.TotalSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Tickets::");
            event1.AvailableSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticket Price::");
            event1.TicketPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Type (Movie,Concert,Sports)::");
            event1.EventTypeType = Console.ReadLine();

            Console.WriteLine("Enter Number of Tickets to Book::");
            int numTickets = int.Parse(Console.ReadLine());

            ticketBookingSystemImpl.CancelTicket(event1, numTickets);

        }

        public void GetAvailableSeats()
        {
            Event1 event1 = new Event1();
            Console.WriteLine("Enter EventName::");
            event1.EventName = Console.ReadLine();
            Console.WriteLine("Enter Event Date::");
            event1.EventDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Time::");
            event1.EventTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Venue Name::");
            event1.VenueName = Console.ReadLine();
            Console.WriteLine("Enter Total Seats::");
            event1.TotalSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Tickets::");
            event1.AvailableSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticket Price::");
            event1.TicketPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Event Type (Movie,Concert,Sports)::");
            event1.EventTypeType = Console.ReadLine();

            ticketBookingSystemImpl.GetAvailableTickets(event1);

        }
    }
}
