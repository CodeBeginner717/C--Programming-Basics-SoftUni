class Operations_Between_Numbers
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        string Operator = Console.ReadLine();

        string EvenOdd = "";

        switch (Operator)
        {
            case "+":
                if ((n1 + n2) % 2 == 0)
                {
                    EvenOdd = "even";
                }
                else
                {
                    EvenOdd = "odd";
                }
                Console.WriteLine($"{n1} + {n2} = {n1 + n2} - {EvenOdd}");
                break;

            case "-":
                if ((n1 - n2) % 2 == 0)
                {
                    EvenOdd = "even";
                }
                else
                {
                    EvenOdd = "odd";
                }
                Console.WriteLine($"{n1} - {n2} = {n1 - n2} - {EvenOdd}");
                break;

            case "*":
                if ((n1 * n2) % 2 == 0)
                {
                    EvenOdd = "even";
                }
                else
                {
                    EvenOdd = "odd";
                }
                Console.WriteLine($"{n1} * {n2} = {n1 * n2} - {EvenOdd}");
                break;

            case "/":
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    Environment.Exit(0);
                }
                Console.WriteLine($"{n1} / {n2} = {(double)n1 / n2:F2}");
                break;

            case "%":
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    Environment.Exit(0);
                }
                Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                break;
        }
    }
}