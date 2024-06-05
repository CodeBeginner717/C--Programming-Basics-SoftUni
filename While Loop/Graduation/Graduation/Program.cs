class Graduation
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();

        double mark = 0.0;
        int grade = 1;
        double sum = 0.0;

        while (grade <= 12)
        {

            mark = double.Parse(Console.ReadLine());
            sum += mark;

            if (mark < 4)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
                return;
            }
            grade++;
        }
        double averageGrade = sum / 12;
        Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
    }
}