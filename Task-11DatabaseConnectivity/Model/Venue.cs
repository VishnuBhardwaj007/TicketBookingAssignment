using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_11DatabaseConnectivity.Model
{
    internal class Venue
    {
        public int venueId;
        public string venueName;
        public string address;



        public Venue()
        {

        }

        //Overloading constructor with parameters:

        public Venue(int Id, string venueName, string venueAddress)
        {
            venueId = Id;
            venueName = venueName;
            address = venueAddress;
        }




        //Getters and Setters:

        public int VenueID
        {
            get { return venueId; }
            set { venueId = value; }    
        }
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
    }
}