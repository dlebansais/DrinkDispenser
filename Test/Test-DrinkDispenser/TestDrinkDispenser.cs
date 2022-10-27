namespace Test_DrinkDispenser;

using DrinkDispenser;
using NUnit.Framework;

[TestFixture]
public class TestDrinkDispenser
{
    [Test]
    public void Basic()
    {
        decimal ExpressoPrice = DrinkDispenser.GetDrinkPrice("Expresso");
        Assert.That(ExpressoPrice, Is.EqualTo(1.2m * 1.3m));

        decimal LongCoffeePrice = DrinkDispenser.GetDrinkPrice("Café allongé");
        Assert.That(LongCoffeePrice, Is.EqualTo(1.4m * 1.3m));
    }

    [Test]
    public void Expresso()
    {
        Recipe TestRecipe = new() { Name = "Expresso", Ingredients = new() { new Dose() { Ingredient = new Ingredient() { Name = "Café", Cost = 1m }, Quantity = 1 }, new Dose() { Ingredient = new Ingredient() { Name = "Eau", Cost = 0.2m }, Quantity = 1 } } };

        Assert.That(TestRecipe.CostPrice, Is.EqualTo(1.2m));
        Assert.That(TestRecipe.Name, Is.EqualTo("Expresso"));
    }

    [Test]
    public void LongCoffee()
    {
        Recipe TestRecipe = new() { Name = "Café allongé", Ingredients = new() { new Dose() { Ingredient = new Ingredient() { Name = "Café", Cost = 1m }, Quantity = 1 }, new Dose() { Ingredient = new Ingredient() { Name = "Eau", Cost = 0.2m }, Quantity = 2 } } };

        Assert.That(TestRecipe.CostPrice, Is.EqualTo(1.4m));
        Assert.That(TestRecipe.Name, Is.EqualTo("Café allongé"));
    }

    [Test]
    public void FirstIngredient()
    {
        Ingredient TestIngredient = new() { Name = "Café", Cost = 1m };

        Assert.That(TestIngredient.Name, Is.EqualTo("Café"));
        Assert.That(TestIngredient.Cost, Is.EqualTo(1m));
    }

    [Test]
    public void FirstDose()
    {
        Ingredient TestIngredient = new() { Name = "Café", Cost = 1m };
        Dose TestDose = new() { Ingredient = TestIngredient, Quantity = 1};

        Assert.That(TestDose.Ingredient, Is.EqualTo(TestIngredient));
        Assert.That(TestDose.Quantity, Is.EqualTo(1));
    }
}
