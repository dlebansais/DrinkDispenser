namespace DrinkDispenser;

using System.Collections.Generic;
using System.Linq;

public class Recipe
{
    public string Name { get; init; }
    public List<Dose> Ingredients { get; init; }
    public decimal CostPrice => Ingredients.Sum(dose => dose.Ingredient.Cost * dose.Quantity);
}
