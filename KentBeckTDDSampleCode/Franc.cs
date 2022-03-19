namespace KentBeckTDDSampleCode
{
    public class Franc : Money
    {
        public Franc(decimal amount)
        {
            Amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

    }
}