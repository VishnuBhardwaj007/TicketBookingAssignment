namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter The Number of Tickets");
                int numTickets;

                while (!int.TryParse(Console.ReadLine(), out numTickets) || numTickets <= 0)
                {
                    Console.WriteLine("Please Enter a Valid Number Of Tickets");
                }

                Console.WriteLine("Enter the Category of Ticket [SILVER:-100/- |GOLD:-200/- |DIAMOND:-300/-]");
                string category = Console.ReadLine().ToUpper();
                int totalCost = 0;

                switch (category)
                {
                    case "SILVER":
                        totalCost = numTickets * 100;
                        Console.WriteLine($"Net Payable Amount: {totalCost}");
                        break;
                    case "GOLD":
                        totalCost = numTickets * 200;
                        Console.WriteLine($"Net Payable Amount: {totalCost}");
                        break;
                    case "DIAMOND":
                        totalCost = numTickets * 300;
                        Console.WriteLine($"Net Payable Amount: {totalCost}");
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Category");
                        Console.Clear();
                        continue; // Continue the loop to ask for input again
                }

                Console.WriteLine("Type 'Exit' to stop booking or press Enter to continue:");
            } while (Console.ReadLine().ToUpper() != "EXIT");
            Console.WriteLine("Ticket Booking Process has Stopped");
        }
    }
}
