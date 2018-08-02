using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractTest
{
    [TestClass]
    public class FunWithNumberTest
    {
        [TestMethod]
        public void MultiNUmbers()
        {
            var np1 = new abstract2.OddNumberProvider();
            var expected1 = 945;
            var np2 = new abstract2.EvenNumberProvider();
            var expected2 = 3840;
            var fwm = new abstract2.FunWithMaths();

            var actual1 = fwm.MultiplyNumbers(np1);
            var actual2 = fwm.MultiplyNumbers(np2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void MockNumberTest()
        {
            var nums = new abstract2.MockNumberProvider();

            var expected = 6;
            var fwm = new abstract2.FunWithMaths();
            var actual = fwm.MultiplyNumbers(nums);

            Assert.AreEqual(expected, actual);
        }
    }

    
}

