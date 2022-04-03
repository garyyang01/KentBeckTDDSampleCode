namespace KentBeckTDDSampleCode
{
    public class Money
    {
        protected string _currency;
        protected decimal Amount;


        public Money(decimal amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public decimal GetAmount()
        {
            return Amount;
        }

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

        public virtual Money Times(int multiplier)
        {
            return null;
        }

        public string Currency()
        {
            return _currency;
        }

        public override string ToString()
        {
            return $"{Amount} {_currency}";
        }
    }
}