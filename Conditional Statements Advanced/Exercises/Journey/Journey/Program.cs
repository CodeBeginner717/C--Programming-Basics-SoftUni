class Journey
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        double spendMoney = 0.0;
        string distance = "";
        string type = "";

        if (budget <= 100)
        {
            distance = "Bulgaria";
            if (season == "summer")
            {
                type = "Camp";
                spendMoney = budget * 0.3;
            }
            else
            {
                type = "Hotel";
                spendMoney = budget * 0.7;
            }
        }

        else if (budget <= 1000)
        {
            distance = "Balkans";
            if (season == "summer")
            {
                type = "Camp";
                spendMoney = budget * 0.4;
            }
            else
            {
                type = "Hotel";
                spendMoney = budget * 0.8;
            }
        }

        else
        {
            distance = "Europe";
            type = "Hotel";
            spendMoney = budget * 0.9;
        }

        Console.WriteLine($"Somewhere in {distance}");
        Console.WriteLine($"{type} - {spendMoney:F2}");
    }
}