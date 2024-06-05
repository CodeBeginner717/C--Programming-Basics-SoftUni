class Salary
{
    static void Main(string[] args)
    {
        int tab = int.Parse(Console.ReadLine());
        int salary = int.Parse(Console.ReadLine());

        for (int i = 0; i < tab; i++)
        {
            string websites = Console.ReadLine();

            switch (websites)
            {
                case "Facebook":
                    salary -= 150;
                    break;
                case "Instagram":
                    salary -= 100;
                    break;
                case "Reddit":
                    salary -= 50;
                    break;
            }
        }

        if (salary <= 0)
        {
            Console.WriteLine("You have lost your salary.");
            return;
        }
        else
        {
            Console.WriteLine(salary);
        }
    }
}