using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11DatabaseConnectivity.Model
{
    internal class Customer
    {
        int customerId;
        string customerName;
        string email;

        int phoneNumber;


        //Parameterized Constructor:
        public Customer(int Id,string customerName, string customerEmail, int customerPhoneNumber)
        {
            customerId= Id;
            this.customerName = customerName;
            email = customerEmail;
            phoneNumber = customerPhoneNumber;

        }

        //Getters and Setters:
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
