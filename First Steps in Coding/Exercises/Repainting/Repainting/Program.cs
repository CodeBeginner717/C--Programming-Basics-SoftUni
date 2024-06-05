using System;

class Repainting
{
    static void Main(String[] args)
    {
        int amountOfNylon = int.Parse(Console.ReadLine());
        int amountOfPaint = int.Parse(Console.ReadLine());
        int amountOfThinnerPaint = int.Parse(Console.ReadLine());
        int hoursOfWork = int.Parse(Console.ReadLine());

        double protectiveNylonPrice = (amountOfNylon + 2) * 1.50;
        double paintPrice = (amountOfPaint + 1.1) * 14.50;
        double thinnerPaintPrice = amountOfThinnerPaint * 5;
        double sumForBags = 0.4;

        double totalAmountForMaterials = protectiveNylonPrice + paintPrice + thinnerPaintPrice + sumForBags;
        double totalAmountForBuilders = (totalAmountForMaterials * 0.3) * hoursOfWork;

        double finalSum = totalAmountForMaterials + totalAmountForBuilders;

        Console.WriteLine(finalSum);
    }
}
