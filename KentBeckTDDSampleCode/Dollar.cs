namespace KentBeckTDDSampleCode
{
    public class Dollar
    {
        public decimal Amount;

        public Dollar(decimal i)
        {
            Amount = i;
        }

        public Dollar Times(int i)
        {
            return new Dollar(Amount * i);
        }
    }
}