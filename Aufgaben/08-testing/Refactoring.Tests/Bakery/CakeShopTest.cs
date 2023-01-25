using Xunit;

namespace Testing.Bakery;

public class CakeShopTest
{
    private readonly CakeShop _testee;

    public CakeShopTest()
    {
        this._testee = new CakeShop(default); // todo: use fake
    }

    [Fact]
    public void Create_WhenCakeIsVanillaAndNotVegan_ShouldLogIngredients()
    {
        // todo: implement test
    }
}