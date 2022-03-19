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
            var money = (Money) obj;
            return Amount == money.GetAmount();
        }
    }

    public class Money
    {
        protected decimal Amount;

        public decimal GetAmount()
        {
            return Amount;
        }
    }
}