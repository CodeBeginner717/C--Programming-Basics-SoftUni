class Train_The_Trainers
{
    static void Main(string[] args)
    {
        int juryCount = int.Parse(Console.ReadLine());

        double totalAverageGrade = 0;
        int presentationsCount = 0;

        while (true)
        {
            string presentationName = Console.ReadLine();

            if (presentationName == "Finish")
                break;

            double presentationSumGrade = 0;

            for (int i = 0; i < juryCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                presentationSumGrade += grade;
            }

            double presentationAverageGrade = presentationSumGrade / juryCount;
            Console.WriteLine($"{presentationName} - {presentationAverageGrade:f2}.");
            totalAverageGrade += presentationAverageGrade;
            presentationsCount++;
        }

        double finalAverageGrade = totalAverageGrade / presentationsCount;
        Console.WriteLine($"Student's final assessment is {finalAverageGrade:f2}.");
    }
}
