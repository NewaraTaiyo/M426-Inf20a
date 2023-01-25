namespace Testing.Lotto;

public interface ILuckyNumberCalculator
{
    bool IsCorrectLuckyNumber(int luckyNumber);
}

public class LuckyNumberCalculator : ILuckyNumberCalculator
{
    private readonly int _drawnLuckyNumber;

    public LuckyNumberCalculator(int drawnLuckyNumber)
    {
        _drawnLuckyNumber = drawnLuckyNumber;
    }

    public bool IsCorrectLuckyNumber(int luckyNumber)
    {
        if (luckyNumber is > 6 or < 1)
        {
            throw new ArgumentOutOfRangeException($"{nameof(luckyNumber)} is invalid");
        }

        return _drawnLuckyNumber == luckyNumber;
    }
}