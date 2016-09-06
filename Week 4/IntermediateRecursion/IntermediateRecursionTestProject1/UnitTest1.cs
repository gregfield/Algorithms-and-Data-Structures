using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntermediateRecursion;

namespace IntermediateRecursionTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PowerOfThree()
        {
            PowersOfThree test = new PowersOfThree();

            int testInt = 81;

            bool expected = true;
            bool actual = test.PowerOfThree(testInt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotPowerOfThree()
        {
            PowersOfThree test = new PowersOfThree();

            int testInt = 269;

            bool expected = false;
            bool actual = test.PowerOfThree(testInt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroInputInt()
        {
            PowersOfThree test = new PowersOfThree();

            int testInt = 0;

            bool expected = false;
            bool actual = test.PowerOfThree(testInt);

            Assert.AreEqual(expected, actual);
        }
    }
}
