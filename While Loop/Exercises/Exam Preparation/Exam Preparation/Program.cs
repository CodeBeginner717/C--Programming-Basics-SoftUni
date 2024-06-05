class Exam_Preparation
{
    static void Main(string[] args)
    {
        int poorGradesLimit = int.Parse(Console.ReadLine());
        int poorGradesCount = 0;
        double totalScore = 0;
        int problemsSolved = 0;
        string lastProblem = "";

        while (true)
        {
            string problemName = Console.ReadLine();
            if (problemName == "Enough")
            {
                double averageScore = totalScore / problemsSolved;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {problemsSolved}");
                Console.WriteLine($"Last problem: {lastProblem}");
                break;
            }

            int grade = int.Parse(Console.ReadLine());
            totalScore += grade;
            problemsSolved++;
            lastProblem = problemName;

            if (grade <= 4)
            {
                poorGradesCount++;
                if (poorGradesCount == poorGradesLimit)
                {
                    Console.WriteLine($"You need a break, {poorGradesLimit} poor grades.");
                    break;
                }
            }
        }
    }
}