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
    public class PalindromeTests
    {   
        private readonly Palindrome palindrome;
        public PalindromeTests()
        {
            palindrome = new Palindrome();
        }

        [TestMethod]
        public void TestMethod1()
        {
            bool isPal = palindrome.IsPalindrome(121);
            Assert.AreEqual(true, isPal);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool isPal = palindrome.IsPalindrome(-121);
            Assert.AreEqual(false, isPal);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool isPal = palindrome.IsPalindrome(10);
            Assert.AreEqual(false, isPal);
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool isPal = palindrome.IsPalindrome(-101);
            Assert.AreEqual(false, isPal);
        }
    }
}
