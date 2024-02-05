using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_11DatabaseConnectivity.Model;
using Task_11DatabaseConnectivity.Repository;

namespace Task_11DatabaseConnectivity.TicketBookingSystemService
{
    internal class TicketBookingSystemServiceImpl : ITicketBookingSystemService
    {
        readonly IBookingSystemRepository _bookingSystemRepository;
        public TicketBookingSystemServiceImpl()
        {
            _bookingSystemRepository = new BookingSystemRepositoryImpl();
        }
        public void AvailableNoOfTickets()
        {
            Console.WriteLine("Enter the Event ID to get available number of tickets:");
            int eventId = Convert.ToInt32(Console.ReadLine());

            int availableTickets = _bookingSystemRepository.GetAvailableNoOfTickets(eventId);

            Console.WriteLine($"Available Number of Tickets for Event ID {eventId}: {availableTickets}");
        }

        public void BookTicket()
        {
            Console.WriteLine("Enter the Customer ID:");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event ID:");
            int eventId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number of Tickets:");
            int numTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Total Cost:");
            decimal totalCost = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the Booking Date (yyyy-MM-dd HH:mm:ss):");
            DateTime bookingDate = DateTime.Parse(Console.ReadLine());

            bool bookingStatus = _bookingSystemRepository.BookTickets(customerId, eventId, numTickets, totalCost, bookingDate);

            if (bookingStatus)
            {
                Console.WriteLine("Tickets booked successfully!");
            }
            else
            {
                Console.WriteLine("Error booking tickets. Please check your input or try again later.");
            }
        }

        public void CalculateBookingCost()
        {
            Console.WriteLine("Enter the Event ID:");
            int eventId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number of Tickets:");
            int numTickets = Convert.ToInt32(Console.ReadLine());

            decimal bookingCost = _bookingSystemRepository.CalculateBookingCost(eventId, numTickets);

            if (bookingCost >= 0)
            {
                Console.WriteLine($"Total Booking Cost for Event ID {eventId} with {numTickets} tickets: {bookingCost:C}");
            }
            else
            {
                Console.WriteLine("Error calculating booking cost. Please check your input or try again later.");
            }
        }

        public void CancelBooking()
        {
            Console.WriteLine("Enter the Booking ID to cancel:");
            int bookingId = Convert.ToInt32(Console.ReadLine());

            bool cancelStatus = _bookingSystemRepository.CancelBooking(bookingId);

            if (cancelStatus)
            {
                Console.WriteLine("Booking canceled successfully!");
            }
            else
            {
                Console.WriteLine("Error canceling booking. Please check your input or try again later.");
            }
        }
//--------------------------------------------------------------------------------------------------------------------
        public void CreateEvent()
        {
            Console.WriteLine("Enter event details:");

            Console.Write("Event Name: ");
            string eventName = Console.ReadLine();

            Console.Write("Event Date (yyyy-MM-dd): ");
            DateTime eventDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Event Time (HH:mm:ss): ");
            TimeSpan eventTime = TimeSpan.Parse(Console.ReadLine());

            Console.Write("Venue Name: ");
            string venueName = Console.ReadLine();

            Console.Write("Total Seats: ");
            int totalSeats = int.Parse(Console.ReadLine());

            Console.Write("Available Seats: ");
            int availableSeats = int.Parse(Console.ReadLine());

            Console.Write("Ticket Price: ");
            decimal ticketPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Event Type (Movie/Sports/Concert): ");
            string eventType = Console.ReadLine();

            // Create Event instance
            Event newEvent = new Event(eventName, eventDate, eventTime, venueName, totalSeats, availableSeats, ticketPrice, (Event.Event_Type)Enum.Parse(typeof(Event.Event_Type), eventType));

            // Call CreateEvent function
            bool eventCreated = _bookingSystemRepository.CreateEvent(newEvent);

            if (eventCreated)
            {
                Console.WriteLine("Event created successfully!");
            }
            else
            {
                Console.WriteLine("Failed to create event.");
            }
        }

        public void GetBookingDetails()
        {
            try
            {
                Console.WriteLine("Enter the Booking ID to fetch details:");
                if (int.TryParse(Console.ReadLine(), out int bookingId))
                {
                    List<Booking> bookingDetails = _bookingSystemRepository.GetBookingDetails(bookingId);

                    if (bookingDetails.Count > 0)
                    {
                        Console.WriteLine("Booking details found:");

                        foreach (var booking in bookingDetails)
                        {
                            Console.WriteLine($"Booking ID: {booking.BookingId}");
                            Console.WriteLine($"Customer ID: {booking.CustomerId}");
                            Console.WriteLine($"Event ID: {booking.EventId}");
                            Console.WriteLine($"Number of Tickets: {booking.NumTickets}");
                            Console.WriteLine($"Total Cost: {booking.TotalCost:C}");
                            Console.WriteLine($"Booking Date: {booking.BookingDate}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No booking details found for the provided Booking ID.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for Booking ID. Please enter a valid integer.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void GetEventDetails()
        {
            Console.WriteLine("Enter Event Id::");
            int eventId=int.Parse(Console.ReadLine());
            List<Event> events = _bookingSystemRepository.GetEventDetails(eventId);

            // Display event details
            Console.WriteLine("Event Details:");

            foreach (Event evt in events)
            {
                Console.WriteLine($"Event Name: {evt.EventName}");
                Console.WriteLine($"Event Date: {evt.EventDate.ToShortDateString()}");
                Console.WriteLine($"Event Time: {evt.EventTime}");
                Console.WriteLine($"Venue Name: {evt.VenueName}");
                Console.WriteLine($"Total Seats: {evt.TotalSeats}");
                Console.WriteLine($"Available Seats: {evt.AvailableSeats}");
                Console.WriteLine($"Ticket Price: {evt.TicketPrice:C}");
                Console.WriteLine($"Event Type: {evt.EventType}");
                Console.WriteLine();
            }
        }
    }
//-------------------------------------------------------------------------------------------------------------------
       
    }

