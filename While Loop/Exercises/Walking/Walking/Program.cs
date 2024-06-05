class Walking
{
    static void Main(string[] args)
    {
        int goal = 10000;
        int totalSteps = 0;

        string input = Console.ReadLine();

        while (input != "Going home")
        {
            int steps = int.Parse(input);
            totalSteps += steps;

            if (totalSteps >= goal)
            {
                int stepsOverGoal = totalSteps - goal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOverGoal} steps over the goal!");
                return;
            }

            input = Console.ReadLine();
        }

        int stepsToHome = int.Parse(Console.ReadLine());
        totalSteps += stepsToHome;

        if (totalSteps < goal)
        {
            int stepsNeeded = goal - totalSteps;
            Console.WriteLine($"{stepsNeeded} more steps to reach goal.");
        }
        else
        {
            int stepsOverGoal = totalSteps - goal;
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{stepsOverGoal} steps over the goal!");
        }
    }
}