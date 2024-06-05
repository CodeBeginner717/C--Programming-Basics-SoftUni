class New_House
{
    static void Main(string[] args)
    {
        string flowersType = Console.ReadLine();
        int numberOfFlowers = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());
        double totalSum = 0;

        int roza = 5;
        double daliq = 3.80;
        double lale = 2.80;
        int narcis = 3;
        double gladiola = 2.50;

        if (flowersType == "Roses" && numberOfFlowers > 80)
        {
            totalSum = roza * numberOfFlowers - (roza * numberOfFlowers * 0.1);
        }
        else if (flowersType == "Roses" && numberOfFlowers <= 80)
        {
            totalSum = roza * numberOfFlowers;
        }

        else if (flowersType == "Dahlias" && numberOfFlowers > 90)
        {
            totalSum = daliq * numberOfFlowers - (daliq * numberOfFlowers * 0.15);
        }
        else if (flowersType == "Dahlias" && numberOfFlowers <= 90)
        {
            totalSum = daliq * numberOfFlowers;
        }

        else if (flowersType == "Tulips" && numberOfFlowers > 80)
        {
            totalSum = lale * numberOfFlowers - (lale * numberOfFlowers * 0.15);
        }
        else if (flowersType == "Tulips" && numberOfFlowers <= 80)
        {
            totalSum = lale * numberOfFlowers;
        }
        else if (flowersType == "Narcissus" && numberOfFlowers < 120)
        {
            totalSum = narcis * numberOfFlowers + (narcis * numberOfFlowers * 0.15);
        }
        else if (flowersType == "Narcissus" && numberOfFlowers >= 120)
        {
            totalSum = narcis * numberOfFlowers;
        }
        else if (flowersType == "Gladiolus" && numberOfFlowers < 80)
        {
            totalSum = gladiola * numberOfFlowers + (gladiola * numberOfFlowers * 0.2);
        }
        else if (flowersType == "Gladiolus" && numberOfFlowers >= 80)
        {
            totalSum = gladiola * numberOfFlowers;
        }
        double leftSum = budget - totalSum;

        if (budget >= totalSum)
        {
            Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowersType} and {leftSum:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {Math.Abs(leftSum):F2} leva more.");
        }
    }
}