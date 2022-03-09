using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace KentBeckTDDSampleCode
{
    [TestFixture]
    public class CurrencyTest
    {
        [Test]
        public void Test_Multiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.Equals(10, five.amount);
        }
    }

    public class Dollar
    {
        public Dollar(int i)
        {
        }
    }
}
