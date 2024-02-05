using Task_11DatabaseConnectivity.TicketBookingSystemService;

namespace Task_11DatabaseConnectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketBookingSystemServiceImpl ticketBookingSystemService = new TicketBookingSystemServiceImpl();
            bool exitMenu = false;

            while (!exitMenu)
            {
                Console.WriteLine("Ticket Booking System Menu:");
                Console.WriteLine("1. Create Event");
                Console.WriteLine("2. Get Event Details");
                Console.WriteLine("3. Available Number of Tickets");
                Console.WriteLine("4. Calculate Booking Cost");
                Console.WriteLine("5. Book Ticket");
                Console.WriteLine("6. Cancel Booking");
                Console.WriteLine("7. Get Booking Details");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice (1-8): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ticketBookingSystemService.CreateEvent();
                        break;
                    case "2":
                        ticketBookingSystemService.GetEventDetails();
                        break;
                    case "3":
                        ticketBookingSystemService.AvailableNoOfTickets();
                        break;
                    case "4":
                        ticketBookingSystemService.CalculateBookingCost();
                        break;
                    case "5":
                        ticketBookingSystemService.BookTicket();
                        break;
                    case "6":
                        ticketBookingSystemService.CancelBooking();
                        break;
                    case "7":
                        ticketBookingSystemService.GetBookingDetails();
                        break;
                    case "8":
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                        break;
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("Thank you for using the Ticket Booking System!");
        }
    }
}
