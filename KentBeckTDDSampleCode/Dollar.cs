namespace KentBeckTDDSampleCode
{
    public class Dollar
    {
        public decimal Amount;

        public Dollar(int i)
        {
            Amount = i;
        }

        public void Times(int i)
        {
            Amount *= i;
        }
    }
}