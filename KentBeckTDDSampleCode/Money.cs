namespace KentBeckTDDSampleCode
{
    public class Money
    {
        protected decimal Amount;

        public decimal GetAmount() => Amount;

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return money != null && Amount == money.GetAmount();
        }
    }
}