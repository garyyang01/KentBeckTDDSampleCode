﻿namespace KentBeckTDDSampleCode
{
    public class Franc : Money
    {
        public Franc(decimal amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, "CHF");
        }
    }
}