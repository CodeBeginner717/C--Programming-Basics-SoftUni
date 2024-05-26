using System;

class Sipplies_for_School
{
    static void Main(String[] args)
    {
        int packagesNumberOfPens = int.Parse(Console.ReadLine());
        int packagesNumberOfMarkers = int.Parse(Console.ReadLine());
        int LitersOfDetergent = int.Parse(Console.ReadLine());
        int percentageDiscount = int.Parse(Console.ReadLine());

        double detergentPerLiterPrice = LitersOfDetergent * 1.20;
        double markersPrice = packagesNumberOfMarkers * 7.20;
        double pensPrice = packagesNumberOfPens * 5.80;

        double priceOfEverything = detergentPerLiterPrice + markersPrice + pensPrice;

        double priceWithDiscount = priceOfEverything - (priceOfEverything * ((double)percentageDiscount / 100));

        Console.WriteLine(priceWithDiscount);

    }
}
