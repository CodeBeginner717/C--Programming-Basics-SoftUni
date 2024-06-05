class Summer_Outfit
{
    static void Main(string[] args)
    {
        int gradusi = int.Parse(Console.ReadLine());
        string time = Console.ReadLine();
        string outfit = "";
        string shoes = "";

        if (time == "Morning")
        {
            if (gradusi >= 10 && gradusi <= 18)
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (gradusi > 18 && gradusi <= 24)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
        }
        else if (time == "Afternoon")
        {
            if (gradusi >= 10 && gradusi <= 18)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (gradusi > 18 && gradusi <= 24)
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
        }
        else if (time == "Evening")
        {
            if (gradusi >= 10 && gradusi <= 18)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (gradusi > 18 && gradusi <= 24)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }
        Console.WriteLine($"It's {gradusi} degrees, get your {outfit} and {shoes}.");
    }
}