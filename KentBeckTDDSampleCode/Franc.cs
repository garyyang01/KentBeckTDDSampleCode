namespace KentBeckTDDSampleCode
{
    public class Franc : Money
    {
        public Franc(decimal amount)
        {
            Amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

    }
}