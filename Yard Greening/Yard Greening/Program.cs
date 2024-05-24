using System;

class Yard_Greening
{
    static void Main(string[] args)
    {
        double greenArea = double.Parse(Console.ReadLine());

        double price = greenArea * 7.61;
        double discount = price * 0.18;
        double finalPrice = price - discount;

        Console.WriteLine($"The final price is: {finalPrice} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");
    }
}