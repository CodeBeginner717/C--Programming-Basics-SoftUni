using System;

class Inches_to_Centimeters
{
    static double CentimetersToInches(double centimeters)
    {
        return centimeters * 2.54;
    }

    static void Main(string[] args)
    {
        double centimeters = double.Parse(Console.ReadLine());
        double inches = CentimetersToInches(centimeters);
        Console.WriteLine(inches);
    }
}