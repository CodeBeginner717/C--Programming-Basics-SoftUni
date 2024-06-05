class Fruit_Shop
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string day = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double banana = 0;
        double apple = 0;
        double orange = 0;
        double grapefruit = 0;
        double kiwi = 0;
        double pineapple = 0;
        double grapes = 0;

        if (product != "banana" && product != "apple" && product != "orange" && product != "grapefruit" && product != "kiwi" && product != "pineapple" && product != "grapes")
        {
            Console.WriteLine("error");
            return;
        }

        if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
        {
            if (product == "banana")
                banana = quantity * 2.50;
            else if (product == "apple")
                apple = quantity * 1.20;
            else if (product == "orange")
                orange = quantity * 0.85;
            else if (product == "grapefruit")
                grapefruit = quantity * 1.45;
            else if (product == "kiwi")
                kiwi = quantity * 2.70;
            else if (product == "pineapple")
                pineapple = quantity * 5.50;
            else if (product == "grapes")
                grapes = quantity * 3.85;
        }
        else if (day == "Saturday" || day == "Sunday")
        {
            if (product == "banana")
                banana = quantity * 2.70;
            else if (product == "apple")
                apple = quantity * 1.25;
            else if (product == "orange")
                orange = quantity * 0.90;
            else if (product == "grapefruit")
                grapefruit = quantity * 1.60;
            else if (product == "kiwi")
                kiwi = quantity * 3.00;
            else if (product == "pineapple")
                pineapple = quantity * 5.60;
            else if (product == "grapes")
                grapes = quantity * 4.20;
        }
        else
        {
            Console.WriteLine("error");
            return;
        }

        double totalSum = banana + apple + orange + grapefruit + kiwi + pineapple + grapes;
        Console.WriteLine(totalSum.ToString("F2"));
    }
}