class Min_Number
{
    static void Main(string[] args)
    {
        string input;
        double min = double.MaxValue;

        while ((input = Console.ReadLine()) != "Stop")
        {
            double currentNum = double.Parse(input);

            if (currentNum < min)
            {
                min = currentNum;
            }
        }
        Console.WriteLine(min);
    }
}