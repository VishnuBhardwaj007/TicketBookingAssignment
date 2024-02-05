namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the number of Tickets Avialable:");
            int availTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Tickets to be Booked:");
            int bookTickets = Convert.ToInt32(Console.ReadLine());

            int remTickets = (availTickets - bookTickets);
            remTickets = (remTickets < 0) ? availTickets : remTickets;

            
            if (availTickets >= bookTickets)
            {
                Console.WriteLine("Tickets booked Successfully!");


            }
            else
            {
                Console.WriteLine("Tickets not available.");
                Console.WriteLine($"Tickets Available are:{remTickets}");
            }

        }
    }
}

