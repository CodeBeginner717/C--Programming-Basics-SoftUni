class Number_sequence
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;

        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());

            if (currentNum > max)
            {
                max = currentNum;
            }
            if (currentNum < min)
            {
                min = currentNum;
            }
        }
        Console.WriteLine($"Max number: {max}");
        Console.WriteLine($"Min number: {min}");
    }
}