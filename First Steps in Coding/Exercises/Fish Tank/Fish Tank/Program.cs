using System;

class Fish_Tank
{
    static void Main(String[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double percentage = double.Parse(Console.ReadLine());

        double volumeOfTheAquarium = length * width * height;
        double volumeInLiters = volumeOfTheAquarium / 1000;
        double occupiedSpace = percentage / 100;

        double neededLiters = volumeInLiters * (1 - occupiedSpace);

        Console.WriteLine(neededLiters);
    }
}
