namespace DrinkDispenser;

public class DrinkDispenser
{
    private const decimal PriceMargin = 1.3m;

    public static decimal GetDrinkPrice(string recipeName)
    {
        Recipe Expresso = new() { Name = "Expresso", Ingredients = new() { new Ingredient() { Name = "Café", Cost = 1m }, new Ingredient() { Name = "Eau", Cost = 0.2m } } };
        Recipe LongCoffee = new() { Name = "Café allongé", Ingredients = new() { new Ingredient() { Name = "Café", Cost = 1m }, new Ingredient() { Name = "Eau", Cost = 0.2m }, new Ingredient() { Name = "Eau", Cost = 0.2m } } };

        if (recipeName == Expresso.Name)
            return Expresso.CostPrice * PriceMargin;
        else if (recipeName == LongCoffee.Name)
            return LongCoffee.CostPrice * PriceMargin;

        return 0;
    }
}