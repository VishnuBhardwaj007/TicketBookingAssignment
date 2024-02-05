using Task_7.BookingSystemService;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookingSystem bookingSystem = new BookingSystemImpl();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Create Event");
                Console.WriteLine("2. Calculate Booking Cost");
                Console.WriteLine("3. Book Tickets");
                Console.WriteLine("4. Cancel Booking");
                Console.WriteLine("5. Get Available Number of Tickets");
                Console.WriteLine("6. Get Event Details");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice (1-7): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        bookingSystem.CreateEvent();
                        break;

                    case "2":
                        bookingSystem.CalculateBookingCost();
                        break;

                    case "3":
                        bookingSystem.BookTickets();
                        break;

                    case "4":
                        bookingSystem.CancelBooking();
                        break;

                    case "5":
                        BookingSystem.GetAvailableNoOfTickets();
                        break;

                    case "6":
                        bookingSystem.GetEventDetails();
                        break;

                    case "7":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                        break;
                }
            }

        }
    }
}
