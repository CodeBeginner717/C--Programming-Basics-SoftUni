class Equal_Sums_Even_Odd
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = start; i <= end; i++)
        {
            int evenSum = 0;
            int oddSum = 0;
            int num = i;

            for (int j = 1; j <= 6; j++)
            {
                int digit = num % 10;
                num /= 10;

                if (j % 2 == 0)
                    evenSum += digit;
                else
                    oddSum += digit;
            }

            if (evenSum == oddSum)
            {
                Console.Write(i + " ");
                found = true;
            }
        }

        if (!found)
        {
            return;
        }
    }
}
