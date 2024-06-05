class Fishing_Boat
{
    static void Main(string[] args)
    {
        int budget = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int fishermen = int.Parse(Console.ReadLine());

        int seasonPrice = 0;

        switch (season)
        {
            case "Spring":
                seasonPrice = 3000;
                break;
            case "Summer":
            case "Autumn":
                seasonPrice = 4200;
                break;
            case "Winter":
                seasonPrice = 2600;
                break;
        }

        double discount = 0;

        if (fishermen <= 6)
            discount = 0.10;
        else if (fishermen <= 11)
            discount = 0.15;
        else
            discount = 0.25;

        double totalSeasonPrice = seasonPrice * (1 - discount);

        if (fishermen % 2 == 0 && season != "Autumn")
            totalSeasonPrice *= 0.95;

        if (budget >= totalSeasonPrice)
            Console.WriteLine($"Yes! You have {(budget - totalSeasonPrice):F2} leva left.");
        else
            Console.WriteLine($"Not enough money! You need {(totalSeasonPrice - budget):F2} leva.");
    }
}