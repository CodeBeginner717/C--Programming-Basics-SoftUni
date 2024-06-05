class Invalid_Number
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if (number == 0 || number >= 100 && number <= 200)
        {
            Environment.ExitCode = 0;
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}