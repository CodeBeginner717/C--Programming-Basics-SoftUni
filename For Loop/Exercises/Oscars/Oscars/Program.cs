class Oscars
{
    static void Main(string[] args)
    {
        string actorName = Console.ReadLine();
        double academyPoints = double.Parse(Console.ReadLine());
        int totalAssessors = int.Parse(Console.ReadLine());
        double totalPoints = academyPoints;

        for (int i = 0; i < totalAssessors; i++)
        {
            string assessorsName = Console.ReadLine();
            double assessorsPoints = double.Parse(Console.ReadLine());

            double currentPoints = ((assessorsName.Length * assessorsPoints) / 2);
            totalPoints += currentPoints;

            if (totalPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
                return;
            }
        }
        double neededPoints = 1250.5 - totalPoints;
        Console.WriteLine($"Sorry, {actorName} you need {neededPoints:f1} more!");
    }
}