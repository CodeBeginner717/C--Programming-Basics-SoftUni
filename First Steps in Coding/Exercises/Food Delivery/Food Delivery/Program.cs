using System;

class Food_Delivery
{
    static void Main(String[] args)
    {
        int chickenMenus = int.Parse(Console.ReadLine());
        int fishMenus = int.Parse(Console.ReadLine());
        int vegeterianMenus = int.Parse(Console.ReadLine());

        double chickenMenuPrice = chickenMenus * 10.35;
        double fishMenuPrice = fishMenus * 12.40;
        double vegeterianMenuPrice = vegeterianMenus * 8.15;

        double totalPriceOfMenus = chickenMenuPrice + fishMenuPrice + vegeterianMenuPrice;
        double priceOfDesert = 0.2 * totalPriceOfMenus;

        double priceOfDelivery = 2.50;

        double totalPriceOfDelivery = totalPriceOfMenus + priceOfDesert + priceOfDelivery;

        Console.WriteLine(totalPriceOfDelivery);


    }
}
