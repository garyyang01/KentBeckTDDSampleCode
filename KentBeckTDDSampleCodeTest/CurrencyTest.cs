﻿using KentBeckTDDSampleCode;
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
            Assert.AreEqual(10, product.Amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.Amount);
        }
    }
}