using Testing.Bakery;
using Xunit;

namespace Testing.Lotto;

public class LottoCalculatorTest
{
    private readonly LottoCalculator _testee;

    public LottoCalculatorTest()
    {
        // todo: use Moq
        this._testee = new LottoCalculator(
            default,
            default,
            default);
    }

    [Fact]
    public void Calculate_WhenLottoNumberInvalid_ShouldThrow()
    {
        // todo: implement test
    }
}