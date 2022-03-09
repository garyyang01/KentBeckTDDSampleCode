namespace KentBeckTDDSampleCode
{
    public class Dollar
    {
        public decimal Amount;

        public Dollar(decimal amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            Dollar dollar = (Dollar) obj;
            return dollar.Amount == Amount;
        }
    }
}