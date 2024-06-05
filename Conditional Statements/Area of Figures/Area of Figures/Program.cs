using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double s = a * a;
                Console.WriteLine(s.ToString("F3"));
            }
            else if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double s = a * b;
                Console.WriteLine(s.ToString("F3"));
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double s = Math.PI * r * r;
                Console.WriteLine(s.ToString("F3"));
            }
            else if (shape == "triangle")
            {
                double a = double.Parse((Console.ReadLine()));
                double h = double.Parse((Console.ReadLine()));
                double s = (a * h) / 2;
                Console.WriteLine(s.ToString("F3"));
            }
        }
    }
}