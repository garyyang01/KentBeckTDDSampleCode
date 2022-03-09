using System;
using System.Collections.Generic;
using System.Text;

namespace KentBeckTDDSampleCode
{
    public class Dollar
    {
        public decimal Amount;

        public Dollar(int i)
        {
        }

        public void times(int i)
        {
            Amount = 5 * 2;
        }
    }
}
