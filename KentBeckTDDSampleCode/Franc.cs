namespace KentBeckTDDSampleCode
{
    public class Franc : Money
    {
        public Franc(decimal amount)
        {
            Amount = amount;
            _currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}