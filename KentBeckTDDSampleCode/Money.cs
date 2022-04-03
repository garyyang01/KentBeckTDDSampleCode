﻿namespace KentBeckTDDSampleCode
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
            return money != null && Amount == money.GetAmount() && Currency().Equals(money.Currency());
        }

        public static Dollar Dollar(decimal amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc Franc(decimal amount)
        {
            return new Franc(amount, "CHF");
        }


        public string Currency()
        {
            return _currency;
        }

        public override string ToString()
        {
            return $"{Amount} {_currency}";
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, _currency);
        }
    }
}