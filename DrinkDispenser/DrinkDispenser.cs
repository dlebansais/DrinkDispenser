namespace DrinkDispenser;

public class DrinkDispenser
{
    private const decimal PriceMargin = 1.3m;

    public static decimal GetDrinkPrice(string recipeName)
    {
        Ingredient Coffee = new Ingredient() { Name = "Café", Cost = 1m };
        Ingredient Water = new Ingredient() { Name = "Eau", Cost = 0.2m };
        Recipe Expresso = new() { Name = "Expresso", Ingredients = new() { new Dose() { Ingredient = Coffee, Quantity = 1 }, new Dose() { Ingredient = Water, Quantity = 1 } } };
        Recipe LongCoffee = new() { Name = "Café allongé", Ingredients = new() { new Dose() { Ingredient = Coffee, Quantity = 1 }, new Dose() { Ingredient = Water, Quantity = 2 } } };

        if (recipeName == Expresso.Name)
            return Expresso.CostPrice * PriceMargin;
        else if (recipeName == LongCoffee.Name)
            return LongCoffee.CostPrice * PriceMargin;

        return 0;
    }
}