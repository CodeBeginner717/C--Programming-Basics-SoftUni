class Number_Pyramid
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int num = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (num <= n)
                {
                    Console.Write(num + " ");
                    num++;
                }
            }
            Console.WriteLine();
        }
    }
}
