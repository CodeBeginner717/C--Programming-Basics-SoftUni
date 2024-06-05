class Vacation
{
    static void Main(string[] args)
    {
        double excursionCost = double.Parse(Console.ReadLine());
        double availableMoney = double.Parse(Console.ReadLine());

        int spendDays = 0;
        int totalDays = 0;

        while (availableMoney < excursionCost && spendDays < 5)
        {
            string action = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            totalDays++;

            if (action == "spend")
            {
                availableMoney -= amount;
                if (availableMoney < 0)
                {
                    availableMoney = 0;
                }
                spendDays++;
            }
            else if (action == "save")
            {
                availableMoney += amount;
                spendDays = 0;
            }
        }

        if (spendDays == 5)
        {
            Console.WriteLine($"You can't save the money.");
            Console.WriteLine($"{totalDays}");
        }
        else
        {
            Console.WriteLine($"You saved the money for {totalDays} days.");
        }
    }
}
