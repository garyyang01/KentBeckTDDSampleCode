namespace KentBeckTDDSampleCode
{
    public class Franc
    {
        private decimal _amount;

        public Franc(decimal amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            Franc franc = (Franc)obj;
            return franc._amount == _amount;
        }
    }
}