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
            Dollar product = five.Times(2);
            Assert.AreEqual(new Dollar(10), five.Times(2));
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }
        [Test]
        public void Test_Equality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}