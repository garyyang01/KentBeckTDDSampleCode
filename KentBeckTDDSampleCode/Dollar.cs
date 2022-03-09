namespace KentBeckTDDSampleCode
{
    public class Dollar
    {
        public decimal Amount;

        public Dollar(int i)
        {
            Amount = i;
        }

        public Dollar Times(int i)
        {
            Amount *= i;
            return null;
        }
    }
}