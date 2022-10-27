namespace DrinkDispenser;

using System.Collections.Generic;
using System.Linq;

public class Recipe
{
    public string Name { get; init; }
    public List<Ingredient> Ingredients { get; init; }
    public decimal CostPrice => Ingredients.Sum(ingredient => ingredient.Cost);
}
