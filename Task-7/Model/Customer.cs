using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Model
{
    internal class Customer
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Constructors
        public Customer()
        {
           
        }

        public Customer(string customerName, string email, string phoneNumber)
        {
         
            CustomerName = customerName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        
        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
    }
}
