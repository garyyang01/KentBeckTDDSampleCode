namespace KentBeckTDDSampleCode
{
    public class Franc : Money
    {
        public Franc(decimal amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier, "CHF");
        }
    }
}