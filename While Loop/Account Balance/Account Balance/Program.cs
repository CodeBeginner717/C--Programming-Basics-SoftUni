class Account_Balance
{
    static void Main(string[] args)
    {
        double total = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "NoMoreMoney")
            {
                break;
            }

            double amount;
            if (!double.TryParse(input, out amount) || amount < 0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }

            Console.WriteLine("Increase: " + amount.ToString("F2"));
            total += amount;
        }

        Console.WriteLine("Total: " + total.ToString("F2"));
    }
}