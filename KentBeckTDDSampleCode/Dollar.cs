namespace KentBeckTDDSampleCode
{
    public class Dollar
    {
        private readonly decimal _amount;

        public Dollar(decimal amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            var dollar = (Dollar) obj;
            return dollar._amount == _amount;
        }
    }
}