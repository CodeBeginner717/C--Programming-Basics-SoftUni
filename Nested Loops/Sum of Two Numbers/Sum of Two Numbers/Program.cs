class Sum_of_Two_Numbers
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int combinationsCount = 0;
        bool combinationFound = false;

        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                combinationsCount++;

                if (i + j == magicNumber)
                {
                    Console.WriteLine($"Combination N:{combinationsCount} ({i} + {j} = {magicNumber})");
                    combinationFound = true;
                    break;
                }
            }

            if (combinationFound)
            {
                break;
            }
        }

        if (!combinationFound)
        {
            Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNumber}");
        }
    }
}