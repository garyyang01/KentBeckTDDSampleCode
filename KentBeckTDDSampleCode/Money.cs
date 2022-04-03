namespace KentBeckTDDSampleCode
{
    public abstract class Money
    {
        protected decimal Amount;
        protected string _currency;

        public decimal GetAmount() => Amount;

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return money != null && Amount == money.GetAmount() && GetType() == money.GetType();
        }

        public static Dollar Dollar(decimal amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc Franc(decimal amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract Money Times(int multiplier);

        public string Currency()
        {
            return _currency;
        }
    }
}