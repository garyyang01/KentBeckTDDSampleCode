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

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Franc Franc(int amount)
        {
            return new Franc(amount);
        }

        public abstract Money Times(int multiplier);

        public string Currency()
        {
            return _currency;
        }
    }
}