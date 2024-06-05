class Trekking_Mania
{
    static void Main(string[] args)
    {
        int totalGroups = int.Parse(Console.ReadLine());

        int musalaCount = 0;
        int monblanCount = 0;
        int kilimanjaroCount = 0;
        int k2Count = 0;
        int everestCount = 0;
        int totalCount = 0;

        for (int i = 0; i < totalGroups; i++)
        {
            int groupSize = int.Parse(Console.ReadLine());
            totalCount += groupSize;

            if (groupSize <= 5)
            {
                musalaCount += groupSize;
            }
            else if (groupSize <= 12)
            {
                monblanCount += groupSize;
            }
            else if (groupSize <= 25)
            {
                kilimanjaroCount += groupSize;
            }
            else if (groupSize <= 40)
            {
                k2Count += groupSize;
            }
            else
            {
                everestCount += groupSize;
            }
        }



        double musalaPercentage = musalaCount / (double)totalCount * 100;
        double monblanPercentage = monblanCount / (double)totalCount * 100;
        double kilimanjaroPercentage = kilimanjaroCount / (double)totalCount * 100;
        double k2Percentage = k2Count / (double)totalCount * 100;
        double everestPercentage = everestCount / (double)totalCount * 100;

        Console.WriteLine($"{musalaPercentage:f2}%");
        Console.WriteLine($"{monblanPercentage:f2}%");
        Console.WriteLine($"{kilimanjaroPercentage:f2}%");
        Console.WriteLine($"{k2Percentage:f2}%");
        Console.WriteLine($"{everestPercentage:f2}%");
    }
}