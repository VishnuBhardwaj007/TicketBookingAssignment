using Task_8_Interfaces_Abstrac__classes.Repository;
using Task_8_Interfaces_Abstrac__classes.Model;
using Task_8_Interfaces_Abstrac__classes.Services;

namespace Task_8_Interfaces_Abstrac__classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AppServices appServices = new AppServices();

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Create Event");
                Console.WriteLine("2. Get Available Tickets");
                Console.WriteLine("3. Get Event Details");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":

                        appServices.EventCreate();
                        break;
                    case "2":

                        appServices.EventDetails();
                        break;
                    case "3":
                        appServices.SeatsAvailable();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

            }










                // Create an instance of BookingSystemServiceProviderImpl
                //IEventServiceProvider eventServiceProvider = new EventServiceProviderImpl();

                //// Create a sample event
                //Venue sampleVenu = new Venue("Sample Venue", "Sample Address");
                //Event createdEvent = eventServiceProvider.CreateEvent("Sample Event", "2024-03-01", "18:00", 100, 20.5m, "Concert", sampleVenu);

                //// Display event details
                //Console.WriteLine("Event Details:");
                //Event[] events = eventServiceProvider.GetEventDetails();

                //foreach (Event ev in events)
                //{
                //    Console.WriteLine($"Event: {ev.EventName}, Date: {ev.EventDate}, Time: {ev.EventTime}, Seats: {ev.TotalSeats}, Price: {ev.TicketPrice}, Type: {ev.EventType}, Venue: {ev.VenueName}");
                //}


                //// Call the GetAvailableNoOfTickets method
                //if (createdEvent != null)
                //{
                //    Console.WriteLine("Event created successfully.");

                //    // Call the GetAvailableNoOfTickets method
                //    int availableTickets = eventServiceProvider.GetAvailableNoOfTickets("MovieNight");

                //    if (availableTickets != -1)
                //    {
                //        Console.WriteLine($"Available Tickets: {availableTickets}");
                //    }




                //// Book tickets for the sample event
                //Customer[] customers = new Customer[]
                //{
                //    new Customer("John Doe", "john@example.com", "123-456-7890"),
                //    new Customer("Jane Doe", "jane@example.com", "987-654-3210")
                //};
                //bookingSystem.BookTickets("Sample Event", 2, customers);

                //// Display available seats after booking
                //Console.WriteLine($"Available Seats after Booking: {bookingSystem.GetAvailableNoOfTickets("Sample Event")}");

                //// Create more events and test other methods as needed
                //// ...

                //Console.ReadLine(); // Keep console open for viewing output


            }
    }
    }

