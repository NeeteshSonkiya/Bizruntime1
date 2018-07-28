using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netAndNunitTest
{
    class TestCase
    {
        public class TestClass
        {
            [TestCase]
            public void AddTest()
            {
                MathsHelper helper = new MathsHelper();
                int result = helper.add(20, 10);
                Assert.AreEqual(30, result);
            }
            [TestCase]
            public void NAddTest()
            {
                MathsHelper helper = new MathsHelper();
                int result = helper.add(20, 10);
                Assert.AreEqual(32, result);
            }

            [TestCase]
            public void SubtractTest()
            {
                MathsHelper helper = new MathsHelper();
                int result = helper.sub(20, 10);
                Assert.AreEqual(10, result);
            }
            [TestCase]
            public void NSubtractTest()
            {
                MathsHelper helper = new MathsHelper();
                int result = helper.sub(20, 10);
                Assert.AreEqual(14, result);
            }
        }
    }
}
