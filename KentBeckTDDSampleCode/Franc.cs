namespace KentBeckTDDSampleCode
{
    public class Franc : Money
    {
        private readonly string _currency;

        public Franc(decimal amount)
        {
            Amount = amount;
            _currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public string Currency()
        {
            return _currency;
        }
    }
}