class Cinema_Tickets
{
    static void Main(string[] args)
    {
        string movieName = Console.ReadLine();
        int totalTickets = 0;
        int studentTickets = 0;
        int standardTickets = 0;
        int kidsTickets = 0;

        while (movieName != "Finish")
        {
            int freeSeats = int.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();

            int soldTickets = 0;

            while (ticketType != "End")
            {
                totalTickets++;
                soldTickets++;

                if (ticketType == "student")
                {
                    studentTickets++;
                }
                else if (ticketType == "standard")
                {
                    standardTickets++;
                }
                else if (ticketType == "kid")
                {
                    kidsTickets++;
                }

                if (soldTickets >= freeSeats)
                {
                    break;
                }

                ticketType = Console.ReadLine();
            }

            double occupancy = (double)soldTickets / freeSeats * 100;
            Console.WriteLine($"{movieName} - {occupancy:f2}% full.");

            movieName = Console.ReadLine();
        }

        Console.WriteLine($"Total tickets: {totalTickets}");
        Console.WriteLine($"{(double)studentTickets / totalTickets * 100:f2}% student tickets.");
        Console.WriteLine($"{(double)standardTickets / totalTickets * 100:f2}% standard tickets.");
        Console.WriteLine($"{(double)kidsTickets / totalTickets * 100:f2}% kids tickets.");
    }
}
