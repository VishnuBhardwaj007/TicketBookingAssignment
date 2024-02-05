using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Interfaces_Abstrac__classes.Model
{
    internal class Venue
    {
        public string venueName;
        public string address;

        //Default Constructor:
        public Venue()
        {
            Console.WriteLine("venue class constructor called");
        }

        public Venue(string? venueName)
        {
            this.venueName = venueName;
        }

        //Overloading constructor with parameters:

        public Venue(string venueName, string venueAddress)
        {
            this.venueName = venueName;
            address = venueAddress;
        }

        //Getters and Setters:

        public string VenueName
        {
            get { return venueName; }
            set { venueName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public void display_venue_details()
        {
            Console.WriteLine($"Venue Name::{VenueName}");
            Console.WriteLine($"Address::{Address}");
        }

    }
}
