using System;

class Radians_to_Degrees
{
    static void Main(String[] args)
    {

        double radians = double.Parse(Console.ReadLine());
        double degree = radians * 180 / Math.PI;

        Console.WriteLine(degree);
    }
}