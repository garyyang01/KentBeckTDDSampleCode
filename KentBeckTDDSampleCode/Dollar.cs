namespace KentBeckTDDSampleCode
{
    public class Dollar : Money
    {
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
            var dollar = (Dollar) obj;
            return dollar.Amount == Amount;
        }
    }

    public class Money
    {
        protected decimal Amount;
    }
}