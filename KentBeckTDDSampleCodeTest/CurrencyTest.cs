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
            five.Times(2);
            Assert.AreEqual(10, five.Amount);
        }
    }
}