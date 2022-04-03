﻿namespace KentBeckTDDSampleCode
{
    public class Dollar : Money
    {
        public Dollar(decimal amount)
        {
            Amount = amount;
            _currency = "USD";
        }

        public override Money Times(int multiplier)
        {
           return new Dollar(Amount * multiplier);
        }
    }
}