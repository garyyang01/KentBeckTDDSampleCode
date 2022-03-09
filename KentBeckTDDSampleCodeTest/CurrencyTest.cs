using KentBeckTDDSampleCode;
using NUnit.Framework;

namespace KentBeckTDDSampleCodeTest
{
    [TestFixture]
    public class CurrencyTest
    {
        [Test]
        public void Test_Multiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.Equals(10, five.Amount);
        }
    }
}