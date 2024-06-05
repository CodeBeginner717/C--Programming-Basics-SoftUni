class Special_Numbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1111; i <= 9999; i++)
        {
            int currentNumber = i;
            bool isSpecial = true;

            while (currentNumber > 0)
            {
                int digit = currentNumber % 10;

                if (digit == 0 || n % digit != 0)
                {
                    isSpecial = false;
                    break;
                }

                currentNumber /= 10;
            }

            if (isSpecial)
            {
                Console.Write(i + " ");
            }
        }
    }
}
