

namespace Assignment_Tasks.Model
{
    internal class Venue
    {
        string venue_name;
        string address;

        //Default Constructor:
        public Venue()
        {
            
        }

        //Overloading constructor with parameters:

        public Venue(string venueName, string venueAddress)
        {

            venueName = venueName;
            address = venueAddress;
        }


        

        //Getters and Setters:

        public string VenueName
        {
            get { return venue_name;}
            set { venue_name = value;}
        }

        public string Address
        {
            get { return address;}                      
            set { address = value;}
        }


        public void display_venue_details()
        {
            Console.WriteLine($"Venue Name::{VenueName}");
            Console.WriteLine($"Address::{Address}");
        }
        

        }


    }

