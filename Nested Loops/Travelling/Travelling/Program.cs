class Sum_of_Two_Numbers
{
    static void Main(string[] args)
    {
        string destination = Console.ReadLine();

        while (destination != "End")
        {
            double minBudget = double.Parse(Console.ReadLine());
            double savings = 0;

            while (savings < minBudget)
            {
                double currentSavings = double.Parse(Console.ReadLine());
                savings += currentSavings;
            }

            Console.WriteLine($"Going to {destination}!");

            destination = Console.ReadLine();
        }
    }
}