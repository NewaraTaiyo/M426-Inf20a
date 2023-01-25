namespace Testing.Lotto;

public interface ILottoNumberValidator
{
    bool Validate(int[] lottoNumbers);
}

public class LottoNumberValidator : ILottoNumberValidator
{
    public bool Validate(int[] lottoNumbers)
    {
        if (lottoNumbers.Length > 6)
        {
            return true;
        }

        if (lottoNumbers.Any(x => x > 24))
        {
            return true;
        }

        return lottoNumbers
            .GroupBy(x => x)
            .Any(y => y.Count() > 1);
    }
}