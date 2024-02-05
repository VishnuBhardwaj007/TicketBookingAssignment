namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The Number of Tickets");
            int numTickets = Convert.ToInt32(Console.ReadLine());
            if (numTickets <= 0)
            {
                Console.WriteLine("Please Enter Valid Number Of Tickets ");
            }

        ticketType:
            Console.WriteLine("Enter the Category of Ticket [SILVER:-100/- |GOLD:-200/- |DIAMOND:-300/-]");
            string category = Console.ReadLine().ToUpper();
            int totalCost = 0;

            switch (category)

            {

                case "SILVER":
                    totalCost = numTickets * 100;
                    Console.WriteLine($"Net Payable Amount:{totalCost}");
                    break;
                case "GOLD":
                    totalCost = numTickets * 200;
                    Console.WriteLine($"Net Payable Amount:{totalCost}");
                    break;
                case "DIAMOND":
                    totalCost = numTickets * 300;
                    Console.WriteLine($"Net Payable Amount:{totalCost}");
                    break;

                default:
                    Console.WriteLine("Please Enter a Valid Category");
                    Console.Clear();
                    goto ticketType;
            }

        }
    }
}
