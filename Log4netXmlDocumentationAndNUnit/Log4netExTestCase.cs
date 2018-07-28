using NUnit.Framework;
using System;
using log4netAndNunitTest;

namespace log4netAndNunitTest
{
    [TestFixture]
    class Log4netExTestCase
    {
        [Test]
        public void Divide()
        {
            Log4netEx p = new Log4netEx();
            int i = 10, j = 2, c, k;
            c = i / j;
            k = p.Divide(i, j);
            Assert.AreEqual(c, k);
        }

        [Test]
        public void NDivide()
        {
            Log4netEx p = new Log4netEx();
            int i = 10, j = 0, c, k;
            k = p.Divide(i, j);
            throw new DivideByZeroException();

        }
    }
}
