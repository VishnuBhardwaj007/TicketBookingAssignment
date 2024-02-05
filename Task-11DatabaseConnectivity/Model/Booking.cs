using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11DatabaseConnectivity.Model
{
    internal class Booking
    {
        int bookingId;
        int customerId;
        int eventId;
        int numTickets;
        decimal totalCost;
        DateTime bookingDate= DateTime.Now;

        public Booking() { }
        
        public int BookingId { get {  return bookingId; } set {  bookingId = value; } }
        public int CustomerId { get { return customerId; } set { customerId = value; } }
        public int EventId { get { return eventId; } set {  eventId = value; } }
        public int NumTickets { get{ return numTickets; } set { numTickets = value; } } 
        public decimal TotalCost { get {  return totalCost; } set {  totalCost = value; } }
        public DateTime BookingDate { get {  return bookingDate; } set { bookingDate = value; } }   


    }
}
