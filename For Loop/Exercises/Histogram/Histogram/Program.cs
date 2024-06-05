class Histogram
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int p1Count = 0, p2Count = 0, p3Count = 0, p4Count = 0, p5Count = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 200)
            {
                p1Count++;
            }
            else if (num >= 200 && num <= 399)
            {
                p2Count++;
            }
            else if (num >= 400 && num <= 599)
            {
                p3Count++;
            }
            else if (num >= 600 && num <= 799)
            {
                p4Count++;
            }
            else
            {
                p5Count++;
            }
        }

        double p1Percent = (double)p1Count / n * 100;
        double p2Percent = (double)p2Count / n * 100;
        double p3Percent = (double)p3Count / n * 100;
        double p4Percent = (double)p4Count / n * 100;
        double p5Percent = (double)p5Count / n * 100;

        Console.WriteLine($"{p1Percent:f2}%");
        Console.WriteLine($"{p2Percent:f2}%");
        Console.WriteLine($"{p3Percent:f2}%");
        Console.WriteLine($"{p4Percent:f2}%");
        Console.WriteLine($"{p5Percent:f2}%");
    }
}