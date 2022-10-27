namespace DrinkDispenser;

public class DrinkDispenser
{
    private const decimal PriceMargin = 1.3m;

    public static decimal GetDrinkPrice(string recipeName)
    {
        Recipe Expresso = new() { Name = "Expresso", CostPrice = 1.2m };
        Recipe LongCoffee = new() { Name = "Café allongé", CostPrice = 1.4m };

        if (recipeName == Expresso.Name)
            return Expresso.CostPrice * PriceMargin;
        else if (recipeName == LongCoffee.Name)
            return LongCoffee.CostPrice * PriceMargin;

        return 0;
    }
}