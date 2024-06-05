class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string city = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double coffee = 0;
        double water = 0;
        double beer = 0;
        double sweets = 0;
        double peanuts = 0;

        if (city == "Sofia")
        {
            if (product == "coffee")
                coffee = quantity * 0.50;
            else if (product == "water")
                water = quantity * 0.80;
            else if (product == "beer")
                beer = quantity * 1.20;
            else if (product == "sweets")
                sweets = quantity * 1.45;
            else if (product == "peanuts")
                peanuts = quantity * 1.60;
        }
        else if (city == "Plovdiv")
        {
            if (product == "coffee")
                coffee = quantity * 0.40;
            else if (product == "water")
                water = quantity * 0.70;
            else if (product == "beer")
                beer = quantity * 1.15;
            else if (product == "sweets")
                sweets = quantity * 1.30;
            else if (product == "peanuts")
                peanuts = quantity * 1.50;
        }
        else if (city == "Varna")
        {
            if (product == "coffee")
                coffee = quantity * 0.45;
            else if (product == "water")
                water = quantity * 0.70;
            else if (product == "beer")
                beer = quantity * 1.10;
            else if (product == "sweets")
                sweets = quantity * 1.35;
            else if (product == "peanuts")
                peanuts = quantity * 1.55;
        }

        double totalPrice = coffee + water + beer + sweets + peanuts;
        Console.WriteLine(totalPrice.ToString("F2"));
    }
}