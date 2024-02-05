using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_11DatabaseConnectivity.Model;
using Task_11DatabaseConnectivity.utility;
using static Task_11DatabaseConnectivity.Model.Event;

namespace Task_11DatabaseConnectivity.Repository
{
    internal class BookingSystemRepositoryImpl : IBookingSystemRepository
    {

        public string connectionString;
        //sql connection class
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;

        public BookingSystemRepositoryImpl()
        {
            connectionString = DBConnection.GetConnectionString();
            cmd = new SqlCommand();
        }
//----------------------------------------------------------------------------------------------------------------------
        public bool BookTickets(int customerId, int eventId, int numTickets, decimal totalCost, DateTime bookingDate)
        {
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(connectionString))
                {
                    sqlconnection.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlconnection;
                        cmd.CommandText = "INSERT INTO Booking (CustomerId, EventId, NumTickets, TotalCost, BookingDate) " +
                                          "VALUES (@customerId, @eventId, @numTickets, @totalCost, @bookingDate)";
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@eventId", eventId);
                        cmd.Parameters.AddWithValue("@numTickets", numTickets);
                        cmd.Parameters.AddWithValue("@totalCost", totalCost);
                        cmd.Parameters.AddWithValue("@bookingDate", bookingDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error booking tickets: {ex.Message}");
                return false;
            }

        }
        //-----------------------------------------------------------------------------------------------------------------------
        public decimal CalculateBookingCost(int eventId, int numTickets)
        {
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(connectionString))
                {
                    sqlconnection.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlconnection;
                        cmd.CommandText = "SELECT TicketPrice FROM Event WHERE EventId = @eventId";
                        cmd.Parameters.AddWithValue("@eventId", eventId);

                        object ticketPriceResult = cmd.ExecuteScalar();

                        if (ticketPriceResult != null && ticketPriceResult != DBNull.Value)
                        {
                            decimal ticketPrice = Convert.ToDecimal(ticketPriceResult);
                            return ticketPrice * numTickets;
                        }
                        else
                        {
                            // Event not found or TicketPrice is null
                            return -1; // You can choose an appropriate value to indicate an error or not found condition
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculating booking cost: {ex.Message}");
                return -1; // You can choose an appropriate value to indicate an error
            }
        }
         
        //------------------------------------------------------------------------------------------------------------------------
        public bool CancelBooking(int bookingId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    // Get booking details by bookingId
                    using (SqlCommand cmd = new SqlCommand("SELECT event_id, num_tickets FROM Booking WHERE booking_id = @bookingId", sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int eventId = reader.GetInt32(0);
                            int numTickets = reader.GetInt32(1);

                            // Delete  the booking record
                            using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Booking WHERE booking_id = @bookingId", sqlConnection))
                            {
                                deleteCmd.Parameters.AddWithValue("@bookingId", bookingId);
                                deleteCmd.ExecuteNonQuery();
                            }

                            // Updating available seats for the event
                            using (SqlCommand updateCmd = new SqlCommand("UPDATE Event SET available_seats = available_seats + @numTickets WHERE event_id = @eventId", sqlConnection))
                            {
                                updateCmd.Parameters.AddWithValue("@numTickets", numTickets);
                                updateCmd.Parameters.AddWithValue("@eventId", eventId);
                                updateCmd.ExecuteNonQuery();
                            }

                            Console.WriteLine($"Booking with ID {bookingId} canceled successfully.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine($"Booking with ID {bookingId} not found.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error canceling booking: {ex.Message}");
                return false;
            }
        }


        //---------------------------------------------------------------------------------------------------
        public bool CreateEvent(Event @event)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlConnection;
                        cmd.CommandText = "INSERT INTO Events (eventName, eventDate, eventTime, venueName, totalSeats, availableSeats, ticketPrice, eventType) " +
                                          "VALUES (@eventName, @eventDate, @eventTime, @venueName, @totalSeats, @availableSeats, @ticketPrice, @eventType)";

                        cmd.Parameters.AddWithValue("@eventName", @event.EventName);
                        cmd.Parameters.AddWithValue("@eventDate", @event.EventDate);
                        cmd.Parameters.AddWithValue("@eventTime", @event.EventTime);
                        cmd.Parameters.AddWithValue("@venueName", @event.VenueName);
                        cmd.Parameters.AddWithValue("@totalSeats", @event.TotalSeats);
                        cmd.Parameters.AddWithValue("@availableSeats", @event.AvailableSeats);
                        cmd.Parameters.AddWithValue("@ticketPrice", @event.TicketPrice);
                        cmd.Parameters.AddWithValue("@eventType", @event.EventType.ToString());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating event: {ex.Message}");
                return false;
            }
        }


        //---------------------------------------------------------------------------------------------------
        public int GetAvailableNoOfTickets(int eventId)
        {
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(connectionString))
                {
                    sqlconnection.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlconnection;
                        cmd.CommandText = "SELECT AvailableSeats FROM Event WHERE EventId = @eventId";
                        cmd.Parameters.AddWithValue("@eventId", eventId);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            // Event not found or AvailableSeats is null
                            return -1; // You can choose an appropriate value to indicate an error or not found condition
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting available seats: {ex.Message}");
                return -1; 
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public List<Booking> GetBookingDetails(int bookingId)
        {
            List<Booking> bookingDetails = new List<Booking>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Booking WHERE booking_id = @bookingId", sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Booking booking = new Booking
                            {
                                BookingId = reader.GetInt32(0),
                                CustomerId = reader.GetInt32(1),
                                EventId = reader.GetInt32(2),
                                NumTickets = reader.GetInt32(3),
                                TotalCost = reader.GetDecimal(4),
                                BookingDate = reader.GetDateTime(5)
                            };

                            bookingDetails.Add(booking);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting booking details: {ex.Message}");
            }

            return bookingDetails;
        }
        //--------------------------------------------------------------------------------------------------------------------------
        public List<Event> GetEventDetails(int eventId)
        {
            List<Event> eventDetails = new List<Event>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlConnection;
                        cmd.CommandText = "SELECT * FROM Events WHERE eventId = @eventId";
                        cmd.Parameters.AddWithValue("@eventId", eventId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Event_Type eventType;
                                Enum.TryParse(reader["eventType"].ToString(), out eventType);

                                Event eventDetail = new Event(
                                    eventId: Convert.ToInt32(reader["eventId"]),
                                    eventName: reader["eventName"].ToString(),
                                    eventDate: Convert.ToDateTime(reader["eventDate"]),
                                    eventTime: TimeSpan.Parse(reader["eventTime"].ToString()),
                                    venueName: reader["venueName"].ToString(),
                                    totalSeats: Convert.ToInt32(reader["totalSeats"]),
                                    availableSeats: Convert.ToInt32(reader["availableSeats"]),
                                    ticketPrice: Convert.ToDecimal(reader["ticketPrice"]),
                                    eventType: eventType
                                );

                                eventDetails.Add(eventDetail);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting event details: {ex.Message}");
            }

            return eventDetails;
        }
        //----------------------------------------------------------------------------------------------------------------------------
    }
}
