class Toy_Shop
{
    static void Main(string[] args)
    {
        double holidayPrice = double.Parse(Console.ReadLine());
        int puzzle = int.Parse(Console.ReadLine());
        int talkingDoll = int.Parse(Console.ReadLine());
        int plushyBear = int.Parse(Console.ReadLine());
        int minion = int.Parse(Console.ReadLine());
        int truck = int.Parse(Console.ReadLine());
        double leftProfit;

        double totalSum = (puzzle * 2.60) + (talkingDoll * 3) + (plushyBear * 4.10) + (minion * 8.20) + (truck * 2);
        int totalToys = puzzle + talkingDoll + plushyBear + minion + truck;

        if (totalToys >= 50)
        {
            totalSum = totalSum - (totalSum * 0.25);
        }

        double rent = totalSum * 0.1;
        double profit = totalSum - rent;

        if (profit >= holidayPrice)
        {
            leftProfit = profit - holidayPrice;
            Console.WriteLine($"Yes! {leftProfit:F2} lv left.");
        }
        else
        {
            leftProfit = Math.Abs(profit - holidayPrice);
            Console.WriteLine($"Not enough money! {leftProfit:F2} lv needed.");
        }
    }
}