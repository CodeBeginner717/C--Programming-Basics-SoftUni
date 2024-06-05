class Coins
{
    static void Main(string[] args)
    {
        double change = double.Parse(Console.ReadLine());

        int coinsCount = 0;
        int changeInCents = (int)(change * 100);

        while (changeInCents > 0)
        {
            if (changeInCents >= 200)
            {
                changeInCents -= 200;
                coinsCount++;
            }
            else if (changeInCents >= 100)
            {
                changeInCents -= 100;
                coinsCount++;
            }
            else if (changeInCents >= 50)
            {
                changeInCents -= 50;
                coinsCount++;
            }
            else if (changeInCents >= 20)
            {
                changeInCents -= 20;
                coinsCount++;
            }
            else if (changeInCents >= 10)
            {
                changeInCents -= 10;
                coinsCount++;
            }
            else if (changeInCents >= 5)
            {
                changeInCents -= 5;
                coinsCount++;
            }
            else if (changeInCents >= 2)
            {
                changeInCents -= 2;
                coinsCount++;
            }
            else if (changeInCents >= 1)
            {
                changeInCents -= 1;
                coinsCount++;
            }
        }

        Console.WriteLine(coinsCount);
    }
}