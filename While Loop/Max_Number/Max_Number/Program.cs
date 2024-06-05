class Max_Number
{
    static void Main(string[] args)
    {
        string input;
        double max = double.MinValue;

        while ((input = Console.ReadLine()) != "Stop")
        {
            double currentNum = double.Parse(input);

            if (currentNum > max)
            {
                max = currentNum;
            }
        }
        Console.WriteLine(max);
    }
}