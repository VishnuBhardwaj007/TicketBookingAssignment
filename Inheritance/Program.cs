using static Inheritance.EventI;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ServiceTicketBooking serviceTicketBooking = new ServiceTicketBooking();

            List<EventI> events = new List<EventI>();

            while (true)
            {
                Console.WriteLine("******** Ticket Booking System ********");
                Console.WriteLine("1. Book Tickets");
                Console.WriteLine("2. View Event Details");
                Console.WriteLine("3. Cancel Tickets");
                Console.WriteLine("4. Exit");
                Console.WriteLine("***************************************");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        
                        serviceTicketBooking.BookTicket();
                        break;

                    case 2:
                        serviceTicketBooking.DisplayEventDetail();
                      break;

                    case 3:
                        serviceTicketBooking.CancelTickets();
                        break;

                    case 4:
                        Console.WriteLine("Exiting the Ticket Booking System. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
    
   

