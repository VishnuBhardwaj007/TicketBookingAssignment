using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Tasks.Model
{
    internal class Customer
    {
        string customer_name;
        string email;

        int phone_number;


        //Parameterized Constructor:
        public Customer(string customerName, string customerEmail, int customerPhoneNumber)
        {
            customer_name = customerName;
            email = customerEmail;
            phone_number = customerPhoneNumber;

        }

        //Getters and Setters:
        public string CustomerName
        {
            get { return customer_name; }   
            set { customer_name = value; }  
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int PhoneNumber
        { 
            get { return phone_number; }
            set { phone_number = value; } 
        }

        public void display_customer_details()
        {
            Console.WriteLine($"Customer Name::{CustomerName}");
            Console.WriteLine($"Customer email::{Email}");
            Console.WriteLine($"Customer Phone Number::{PhoneNumber}");
        }
    }
}
