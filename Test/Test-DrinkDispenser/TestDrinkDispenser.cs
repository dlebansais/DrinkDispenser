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
    public void FirstRecipe()
    {
        Recipe TestRecipe = new();
        decimal CostPrice = TestRecipe.CostPrice;

        Assert.That(CostPrice, Is.EqualTo(1.2m));
    }
}