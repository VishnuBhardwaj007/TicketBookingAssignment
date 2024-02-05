using System.ComponentModel;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SericeTicketbookingSystem sericeTicketbookingSystem = new SericeTicketbookingSystem();  
            List<Event1> events = new List<Event1>();

            while (true)
            {
                Console.WriteLine("******** Ticket Booking System ********");
                Console.WriteLine("1. Book Tickets");
                Console.WriteLine("2. View Event Details");
                Console.WriteLine("3. Cancel Tickets");
                Console.WriteLine("4. Get Avilable Tickets");
                Console.WriteLine("5. Exit");
                Console.WriteLine("***************************************");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 1:

                        sericeTicketbookingSystem.BookTicket();
                        break;

                    case 2:
                        sericeTicketbookingSystem.DisplayEventDetail();
                        break;

                    case 3:
                        sericeTicketbookingSystem.CancelTickets();
                        break;

                    case 4:

                        sericeTicketbookingSystem.GetAvailableSeats();
                        break;

                    case 5:
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
