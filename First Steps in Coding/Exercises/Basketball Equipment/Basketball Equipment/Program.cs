using System;

class Basketball_Equipment
{
    static void Main(String[] args)
    {
        int annualTaxes = int.Parse(Console.ReadLine());

        double priceOfBasketballShoes = annualTaxes * 0.40;
        priceOfBasketballShoes = annualTaxes - priceOfBasketballShoes;

        double priceOfBasketballOutfit = priceOfBasketballShoes * 0.2;
        priceOfBasketballOutfit = priceOfBasketballShoes - priceOfBasketballOutfit;

        double priceOfBall = priceOfBasketballOutfit * 0.25;

        double priceOfAccessories = priceOfBall * 0.20;

        double totalPriceOfOutfit = annualTaxes + priceOfBasketballShoes + priceOfBasketballOutfit + priceOfBall + priceOfAccessories;

        Console.WriteLine(totalPriceOfOutfit);
    }
}
