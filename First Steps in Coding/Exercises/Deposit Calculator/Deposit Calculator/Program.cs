using System;

class Deposit_Calculator
{
    static void Main(String[] args)
    {

        long depositSum = long.Parse(Console.ReadLine());
        int depositPeriod = int.Parse(Console.ReadLine());
        double annualInterestRate = double.Parse(Console.ReadLine());

        double sum1 = depositSum + (depositPeriod * ((depositSum * annualInterestRate / 100) / 12));

        Console.WriteLine(sum1);
    }
}
