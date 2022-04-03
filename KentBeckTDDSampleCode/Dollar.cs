namespace KentBeckTDDSampleCode
{
    public class Dollar : Money
    {
        public Dollar(decimal amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier, "USD");
        }
    }
}