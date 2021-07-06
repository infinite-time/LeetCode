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

        [TestMethod]
        public void TestMethod2()
        {
            int n = 2;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("11", s);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int n = 3;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("21", s);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int n = 4;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("1211", s);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int n = 5;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("111221", s);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int n = 6;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("312211", s);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int n = 7;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("13112221", s);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int n =8;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("1113213211", s);
        }

        [TestMethod]
        public void TestMethod9()
        {
            int n = 9;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("31131211131221", s);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int n = 10;
            string s = countSay.CountAndSay(n);
            Assert.AreEqual("13211311123113112211", s);
        }
    }
}
