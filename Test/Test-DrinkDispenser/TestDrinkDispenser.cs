namespace Test_DrinkDispenser;

using DrinkDispenser;
using NUnit.Framework;

[TestFixture]
public class TestDrinkDispenser
{
    [Test]
    public void Basic()
    {
        decimal Price = DrinkDispenser.GetDrinkPrice("Expresso");
        Assert.That(Price, Is.EqualTo(1.2m * 1.3m));
    }

    [Test]
    public void Expresso()
    {
        Recipe TestRecipe = new() { Name = "Expresso", CostPrice = 1.2m };

        Assert.That(TestRecipe.CostPrice, Is.EqualTo(1.2m));
        Assert.That(TestRecipe.Name, Is.EqualTo("Expresso"));
    }

    [Test]
    public void LongCoffee()
    {
        Recipe TestRecipe = new() { Name = "Café allongé", CostPrice = 1.4m };

        Assert.That(TestRecipe.CostPrice, Is.EqualTo(1.4m));
        Assert.That(TestRecipe.Name, Is.EqualTo("Café allongé"));
    }
}