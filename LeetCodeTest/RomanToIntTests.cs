using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest
{
    [TestClass]
    public class RomanToIntTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            RomanToInt romanToInt = new RomanToInt();
            int integerEquivalent =  romanToInt.Convert("III");
            Assert.AreEqual(3, integerEquivalent);
        }
        [TestMethod]
        public void TestMethod2()
        {
            RomanToInt romanToInt = new RomanToInt();
            int integerEquivalent = romanToInt.Convert("IV");
            Assert.AreEqual(4, integerEquivalent);
        }
        [TestMethod]
        public void TestMethod3()
        {
            RomanToInt romanToInt = new RomanToInt();
            int integerEquivalent = romanToInt.Convert("IX");
            Assert.AreEqual(9, integerEquivalent);
        }
        [TestMethod]
        public void TestMethod4()
        {
            RomanToInt romanToInt = new RomanToInt();
            int integerEquivalent = romanToInt.Convert("LVIII");
            Assert.AreEqual(58, integerEquivalent);
        }
        [TestMethod]
        public void TestMethod5()
        {
            RomanToInt romanToInt = new RomanToInt();
            int integerEquivalent  = romanToInt.Convert("MCMXCIV");
            Assert.AreEqual(1994, integerEquivalent);
        }
    }
}
