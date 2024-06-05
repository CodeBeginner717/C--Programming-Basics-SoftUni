class Shopping
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int videoCards = int.Parse(Console.ReadLine());
        int processors = int.Parse(Console.ReadLine());
        int RAM = int.Parse(Console.ReadLine());

        double priceVideoCards = 250 * videoCards;
        double priceProcessors = processors * (0.35 * priceVideoCards);
        double priceRAM = RAM * (0.1 * priceVideoCards);

        double totalSum = priceVideoCards + priceProcessors + priceRAM;

        if (videoCards > processors)
        {
            totalSum = totalSum - (totalSum * 0.15);
        }

        if (budget >= totalSum)
        {
            double leftBudget = budget - totalSum;
            Console.WriteLine($"You have {leftBudget:F2} leva left!");
        }
        else
        {
            double neededMoney = Math.Abs(budget - totalSum);
            Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
        }
    }
}