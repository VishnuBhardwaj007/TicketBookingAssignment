namespace Task_5_TicketBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the TicketBookingSystem and some events
            TicketBookingSystem ticketBookingSystem = new TicketBookingSystem();
            Event movieEvent = ticketBookingSystem.CreateEvent("Avengers: Endgame", "2024-02-01", "18:00", 100, 10.99m, "Movie", "Cinema 1");
            Event sportsEvent = ticketBookingSystem.CreateEvent("Football Match", "2024-02-15", "15:30", 50, 15.99m, "Sports", "Stadium A");

            // Display event details using polymorphism
            ticketBookingSystem.DisplayEventDetails(movieEvent);
            ticketBookingSystem.DisplayEventDetails(sportsEvent);

            Console.WriteLine("\t");

            //Book tickets
            ticketBookingSystem.BookTickets(movieEvent, 5);
            ticketBookingSystem.BookTickets(sportsEvent, 2);
            Console.WriteLine("\t");

            // Display updated event details
            ticketBookingSystem.DisplayEventDetails(movieEvent);
            ticketBookingSystem.DisplayEventDetails(sportsEvent);
            Console.WriteLine("\t");

             //Cancel tickets
           //ticketBookingSystem.CancelTickets(movieEvent, 2);
           //ticketBookingSystem.CancelTickets(sportsEvent, 1);

            // Display final event details
            ticketBookingSystem.DisplayEventDetails(movieEvent);
            ticketBookingSystem.DisplayEventDetails(sportsEvent);
        }
    }
    }


