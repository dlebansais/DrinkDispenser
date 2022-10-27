using System.Collections.Generic;

namespace DrinkDispenser;

public class RecipeBuilder
{
    public void AddIngredient(string name, decimal cost)
    {
        Ingredients.Add(name, new Ingredient() { Name = name, Cost = cost });
    }

    public Ingredient GetIngredient(string name)
    {
        return Ingredients[name];
    }

    private Dictionary<string, Ingredient> Ingredients = new();
}
