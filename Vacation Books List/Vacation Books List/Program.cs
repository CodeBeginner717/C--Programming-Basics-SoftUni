using System;

class Vacation_Book_List
{
    static void Main(String[] args)
    {

        int numberOfPages = int.Parse(Console.ReadLine());
        int pagesForHour = int.Parse(Console.ReadLine());
        int numberOfDays = int.Parse(Console.ReadLine());

        int numberOfHours = (numberOfPages / pagesForHour) / numberOfDays;

        Console.WriteLine(numberOfHours);
    }
}