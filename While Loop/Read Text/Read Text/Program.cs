class Read_Text
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "Stop")
        {
            Console.WriteLine(input);
            input = Console.ReadLine();
        }
    }
}