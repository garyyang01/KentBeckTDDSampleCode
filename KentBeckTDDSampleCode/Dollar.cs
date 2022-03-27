namespace KentBeckTDDSampleCode
{
    public class Dollar : Money
    {
        public Dollar(decimal amount)
        {
            Amount = amount;
        }

        public Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}