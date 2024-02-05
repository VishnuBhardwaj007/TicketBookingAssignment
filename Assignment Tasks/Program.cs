using Assignment_Tasks.Model;
using static Assignment_Tasks.Model.Event;

namespace Assignment_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of the Event class
            Event myEvent = new Event(
                eventName: "Movie Night",
                eventDate: DateTime.Now.AddDays(7),
                eventTime: new TimeSpan(18, 30, 0),
                venueName: "Cinema Hall 1",
                totalSeats: 100,
                availableSeats: 80,
            ticketPrice: 12.50m,
                 eventType: Event_Type.Movie
            ) ;

            // Calculate Total Revenue
            Console.WriteLine(myEvent.Calculate_Total_Revenue());
           

            //Example of booking tickets
            myEvent.BookTickets(2);

            //Displaying updated event details
            myEvent.DisplayEventDetails();

            //Example of canceling booking
            myEvent.CancelBooking(1);

            //Displaying final event details
            myEvent.DisplayEventDetails();



            //Creating object for Venue:
            Venue venue = new Venue("Ambience","Gurgaon");
            venue.display_venue_details();

            //Creating Instance of Booking Class:
            Booking myBooking = new Booking(myEvent);

            // Displaying initial event details
            Console.WriteLine(myBooking.GetEventDetails());

            // Booking tickets
            myBooking.BookTickets(3);

            // Displaying updated event details after booking
            Console.WriteLine(myBooking.GetEventDetails());

            
            // Canceling booking
            myBooking.CancelBooking(1);

            // Displaying updated event details after cancellation
            Console.WriteLine(myBooking.GetEventDetails());

          
        }
    }
}
