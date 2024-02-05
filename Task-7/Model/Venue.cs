using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Model
{
    internal class Venue
    {
        private string venueName;
        private string address;
        private int v1;
        private string v2;

        // Constructors
        public Venue()
        {
            // Default constructor
        }

        public Venue(string venueName, string address)
        {
            this.venueName = venueName;
            this.address = address;
        }

        public Venue(int v1, string? venueName, string v2)
        {
            this.v1 = v1;
            this.venueName = venueName;
            this.v2 = v2;
        }

        // Getter and Setter for Venue Name
        public string VenueName
        {
            get { return venueName; }
            set { venueName = value; }
        }

        // Getter and Setter for Address
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Method to display venue details
        public void DisplayVenueDetails()
        {
            Console.WriteLine($"Venue Name: {venueName}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
