namespace DrinkDispenser;

public class DrinkDispenser
{
    private const decimal PriceMargin = 1.3m;

    public static decimal GetDrinkPrice(string recipeName)
    {
        Ingredient Coffee = new Ingredient() { Name = "Café", Cost = 1m };
        Ingredient Water = new Ingredient() { Name = "Eau", Cost = 0.2m };
        Recipe Expresso = new() { Name = "Expresso", Ingredients = new() { Coffee, Water } };
        Recipe LongCoffee = new() { Name = "Café allongé", Ingredients = new() { Coffee, Water, Water } };

        if (recipeName == Expresso.Name)
            return Expresso.CostPrice * PriceMargin;
        else if (recipeName == LongCoffee.Name)
            return LongCoffee.CostPrice * PriceMargin;

        return 0;
    }
}