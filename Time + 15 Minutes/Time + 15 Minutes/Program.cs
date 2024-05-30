class Time_plus_15_Minutes
{
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int totalMinutes = hour * 60 + minutes;
        totalMinutes += 15;

        int newHour = totalMinutes / 60;
        int newMinutes = totalMinutes % 60;

        if (newHour >= 24)
        {
            newHour -= 24;
        }

        Console.WriteLine($"{newHour}:{newMinutes:D2}");
    }
}