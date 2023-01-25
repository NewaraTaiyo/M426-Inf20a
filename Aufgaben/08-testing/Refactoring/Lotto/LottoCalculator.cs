namespace Testing.Lotto
{
    public class LottoCalculator
    {
        private readonly ILottoNumberValidator _lottoNumberValidator;
        private readonly ILuckyNumberCalculator _luckyNumberCalculator;
        private readonly ILottoNumberRetriever _lottoNumberRetriever;

        public LottoCalculator(
            ILottoNumberValidator lottoNumberValidator,
            ILuckyNumberCalculator luckyNumberCalculator,
            ILottoNumberRetriever lottoNumberRetriever)
        {
            _lottoNumberValidator = lottoNumberValidator;
            _luckyNumberCalculator = luckyNumberCalculator;
            _lottoNumberRetriever = lottoNumberRetriever;
        }

        public int Calculate(int[] lottoNumbers, int luckyNumber)
        {
            var resultMultiplication = 1;

            if (_lottoNumberValidator.Validate(lottoNumbers))
            {
                throw new ArgumentException("Invalid lotto numbers");
            }

            if (_luckyNumberCalculator.IsCorrectLuckyNumber(luckyNumber))
            {
                resultMultiplication = 2;
            }

            return _lottoNumberRetriever.DrawnLottoNumbers
                .Intersect(lottoNumbers)
                .Count() * 100 * resultMultiplication;
        }
    }
}