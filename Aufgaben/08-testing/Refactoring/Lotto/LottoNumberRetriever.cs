namespace Testing.Lotto;

public interface ILottoNumberRetriever
{
    int[] DrawnLottoNumbers { get; }
}

public class LottoNumberRetriever : ILottoNumberRetriever
{
    public LottoNumberRetriever(int[] drawnLottoNumbers)
    {
        DrawnLottoNumbers = drawnLottoNumbers;
    }

    public int[] DrawnLottoNumbers { get; }
}