namespace DrinkDispenser;

using System.Collections.Generic;

public class Recipe
{
    public string Name { get; init; }
    public List<Ingredient> Ingredients { get; init; }
    public decimal CostPrice { get; init; }
}
