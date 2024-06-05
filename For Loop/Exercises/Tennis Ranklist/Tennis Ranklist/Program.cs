class Tennis_Ranklist
{
    static void Main()
    {
        int tournamentsCount = int.Parse(Console.ReadLine());
        int startingPoints = int.Parse(Console.ReadLine());

        int finalPoints = startingPoints;
        int totalPoints = 0;
        int winsCount = 0;

        for (int i = 0; i < tournamentsCount; i++)
        {
            string tournamentResult = Console.ReadLine();

            switch (tournamentResult)
            {
                case "W":
                    finalPoints += 2000;
                    winsCount++;
                    break;
                case "F":
                    finalPoints += 1200;
                    break;
                case "SF":
                    finalPoints += 720;
                    break;
            }
        }

        totalPoints = finalPoints - startingPoints;
        double averagePoints = Math.Floor((double)totalPoints / tournamentsCount);
        double winPercentage = (double)winsCount / tournamentsCount * 100;

        Console.WriteLine($"Final points: {finalPoints}");
        Console.WriteLine($"Average points: {averagePoints}");
        Console.WriteLine($"{winPercentage:f2}%");
    }
}