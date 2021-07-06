using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest
{
    [TestClass]
    public class CountSayTests
    {
        private readonly CountSay countSay;
        public CountSayTests()
        {
            countSay = new CountSay();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int n = 1;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("1", s);
        }
    }
}
