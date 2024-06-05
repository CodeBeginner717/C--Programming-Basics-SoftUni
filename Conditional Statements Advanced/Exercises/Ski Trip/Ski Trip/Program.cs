class Ski_Trip

{
    public static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        string roomType = Console.ReadLine();
        string review = Console.ReadLine();

        double pricePerNight = 0;

        switch (roomType)
        {
            case "room for one person":
                pricePerNight = 18;
                break;
            case "apartment":
                pricePerNight = 25;
                break;
            case "president apartment":
                pricePerNight = 35;
                break;
        }

        double totalPrice = (days - 1) * pricePerNight;

        if (days > 15 && roomType == "president apartment")
        {
            totalPrice *= 0.8;
        }
        else if (days > 10 && days <= 15 && roomType == "president apartment")
        {
            totalPrice *= 0.85;
        }
        else if (days < 10 && roomType == "president apartment")
        {
            totalPrice *= 0.9;
        }
        else if (days > 15 && roomType == "apartment")
        {
            totalPrice *= 0.5;
        }
        else if (days > 10 && days <= 15 && roomType == "apartment")
        {
            totalPrice *= 0.65;
        }
        else if (days < 10 && roomType == "apartment")
        {
            totalPrice *= 0.7;
        }

        if (review == "positive")
        {
            totalPrice *= 1.25;
        }
        else
        {
            totalPrice *= 0.9;
        }

        Console.WriteLine($"{totalPrice:F2}");
    }
}