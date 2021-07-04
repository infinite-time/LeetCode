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
    public class LargestCommonPrefixTests
    {
        private readonly LargestCommonPrefix largestCommonPrefix;
        public LargestCommonPrefixTests()
        {
            largestCommonPrefix = new LargestCommonPrefix();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string[] input = {"flower", "flow", "flight"};
            string prefix = largestCommonPrefix.FindLargestCommonPrefix(input);
            Assert.AreEqual("fl", prefix);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] input = { "c", "acc", "cc" };
            string prefix = largestCommonPrefix.FindLargestCommonPrefix(input);
            Assert.AreEqual("", prefix);
        }
    }
}
