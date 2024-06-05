using System;

namespace ExcellentResult
{
    class Even_or_Odd
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

    }
}
