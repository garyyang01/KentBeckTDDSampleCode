namespace KentBeckTDDSampleCode
{
    public class Dollar : Money
    {
        private readonly string _currency;

        public Dollar(decimal amount)
        {
            Amount = amount;
            _currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public string Currency()
        {
            return _currency;
        }
    }
}