using System;

class Projects_Creation
{
    static void Main(string[] args)
    {
        string architectName = Console.ReadLine();
        int numberOfProjects = int.Parse(Console.ReadLine());
        int neededHours = numberOfProjects * 3;

        Console.WriteLine($"The architect {architectName} will need {neededHours} hours to complete {numberOfProjects} project/s.");

    }
}