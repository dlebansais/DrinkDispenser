namespace Test_DrinkDispenser;

using NUnit;
using NUnit.Framework;

[TestFixture]
public class TestDrinkDispenser
{
    [Test]
    public void TestBasic()
    {
        double Price = DrinkDispenser.DrinkDispenser.GetDrinkPrice("Expresso");
        Assert.That(Price, Is.EqualTo(1.2 * 1.3));
    }
}