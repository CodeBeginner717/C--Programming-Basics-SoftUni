class Clever_Lily
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        double totalMoney = 0;
        int toyCount = 0;
        double brotherMoney = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                totalMoney += (i * 10) / 2;
                brotherMoney++;
            }
            else
            {
                toyCount++;
            }
        }

        totalMoney += toyCount * toyPrice;
        totalMoney -= brotherMoney;

        if (totalMoney >= washingMachinePrice)
        {
            Console.WriteLine($"Yes! {totalMoney - washingMachinePrice:f2}");
        }
        else
        {
            Console.WriteLine($"No! {washingMachinePrice - totalMoney:f2}");
        }
    }
}