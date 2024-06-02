class Lunch_Break
{
    static void Main(string[] args)
    {
        string serialName = Console.ReadLine();
        int episodeDuration = int.Parse(Console.ReadLine());
        int restDuration = int.Parse(Console.ReadLine());

        double timeForLunch = 0.125 * restDuration;
        double timeForRest = 0.25 * restDuration;
        double timeLeft = restDuration - timeForLunch - timeForRest;

        double totalTimeLeft = timeLeft - episodeDuration;

        if (timeLeft >= episodeDuration)
        {
            Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(totalTimeLeft)} minutes free time.");
        }
        else
        {
            totalTimeLeft = episodeDuration - timeLeft;
            Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(totalTimeLeft)} more minutes.");
        }
    }
}