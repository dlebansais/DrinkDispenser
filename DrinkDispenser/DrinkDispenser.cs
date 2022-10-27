namespace DrinkDispenser;

public class DrinkDispenser
{
    public static decimal GetDrinkPrice(string recipeName)
    {
        Recipe Expresso = new() { Name = "Expresso", CostPrice = 1.2m };
        Recipe LongCoffee = new() { Name = "Café allongé", CostPrice = 1.4m };

        if (recipeName == Expresso.Name)
            return Expresso.CostPrice * 1.3m;
        else if (recipeName == LongCoffee.Name)
            return LongCoffee.CostPrice * 1.3m;

        return 0;
    }
}