using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netAndNunitTest
{
    [TestFixture]
    public class SquareTest
    {
        [TestCase]
        public void squareTest()
        {
            MathHelper helper = new MathHelper();
            int result = helper.square(5);
            Assert.AreEqual(25, result);
        }
        [TestCase]
        public void NSquareTest()
        {
            MathHelper helper = new MathHelper();
            int result = helper.square(5);
            Assert.AreEqual(24, result);
        }
    }
}

