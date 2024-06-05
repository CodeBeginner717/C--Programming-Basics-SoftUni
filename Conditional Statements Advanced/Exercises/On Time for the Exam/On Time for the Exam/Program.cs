class On_Time_for_the_Exam
{
    public static void Main(string[] args)
    {

        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());

        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinute = int.Parse(Console.ReadLine());

        int examTimeInMinutes = examHour * 60 + examMinute;
        int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;

        int differenceInMinutes = arrivalTimeInMinutes - examTimeInMinutes;

        if (differenceInMinutes > 0)
        {

            Console.WriteLine("Late");

            if (differenceInMinutes < 60)
            {
                Console.WriteLine($"{differenceInMinutes} minutes after the start");
            }
            else
            {
                int hours = differenceInMinutes / 60;
                int minutes = differenceInMinutes % 60;
                Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
            }
        }
        else if (differenceInMinutes >= -30)
        {

            Console.WriteLine("On time");

            if (differenceInMinutes != 0)
            {
                Console.WriteLine($"{Math.Abs(differenceInMinutes)} minutes before the start");
            }
        }
        else
        {

            Console.WriteLine("Early");

            int absDifference = Math.Abs(differenceInMinutes);
            if (absDifference < 60)
            {
                Console.WriteLine($"{absDifference} minutes before the start");
            }
            else
            {
                int hours = absDifference / 60;
                int minutes = absDifference % 60;
                Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
            }
        }
    }
}