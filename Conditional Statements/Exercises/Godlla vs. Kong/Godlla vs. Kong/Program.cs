class Godzilla_vs_Kong
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int extras = int.Parse(Console.ReadLine());
        double outfitPrice = double.Parse(Console.ReadLine());
        double decor = 0.1 * budget;

        if (extras > 150)
        {
            outfitPrice = outfitPrice - (outfitPrice * 0.1);
        }

        double totalOutfitPrice = extras * outfitPrice;
        double filmPrice = decor + totalOutfitPrice;

        double leftOvers = Math.Abs(budget - filmPrice);

        if (decor + totalOutfitPrice > budget)
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {leftOvers:F2} leva more.");
        }
        else
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {leftOvers:F2} leva left.");
        }
    }
}
