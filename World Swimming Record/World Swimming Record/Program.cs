class World_Swimming_Record
{
    static void Main(string[] args)
    {
        double recordInSeconds = double.Parse(Console.ReadLine());
        double meters = double.Parse(Console.ReadLine());
        double timeInSeconds1m = double.Parse(Console.ReadLine());

        double swimAcrossInTime = meters * timeInSeconds1m;
        double delayInSeconds = (int)(meters / 15) * 12.5;

        double totalTime = swimAcrossInTime + delayInSeconds;

        if (recordInSeconds > totalTime)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
        }
        else
        {
            double secondsAway = Math.Abs(recordInSeconds - totalTime);
            Console.WriteLine($"No, he failed! He was {secondsAway:F2} seconds slower.");
        }
    }
}