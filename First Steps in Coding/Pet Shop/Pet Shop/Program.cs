using System;

class Pet_Shop
{
    static void Main(string[] args)
    {
        int dogFood = int.Parse(Console.ReadLine());
        int catFood = int.Parse(Console.ReadLine());

        double dogFoodPrice = dogFood * 2.50;
        double catFoodPrice = catFood * 4.00;

        Console.WriteLine(dogFoodPrice + catFoodPrice + " lv.");

    }
}