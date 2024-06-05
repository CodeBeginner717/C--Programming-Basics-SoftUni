class Moving
{
    static void Main(string[] args)
    {
        int cakeWidth = int.Parse(Console.ReadLine());
        int cakeLength = int.Parse(Console.ReadLine());

        int cakeSize = cakeWidth * cakeLength;
        string input = Console.ReadLine();

        while (input != "STOP")
        {
            int piecesTaken = int.Parse(input);
            cakeSize -= piecesTaken;

            if (cakeSize < 0)
            {
                int neededPieces = Math.Abs(cakeSize);
                Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
                return;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"{cakeSize} pieces are left.");
    }
}

