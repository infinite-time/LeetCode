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
    public class SearchInsertPositionTests
    {
        private readonly SearchInsertPosition searchInsertPosition;
        public SearchInsertPositionTests()
        {
            searchInsertPosition = new SearchInsertPosition();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;
            int index = searchInsertPosition.SearchInsert(nums, target);
            Assert.AreEqual(2, index);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 2;
            int index = searchInsertPosition.SearchInsert(nums, target);
            Assert.AreEqual(1, index);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 7;
            int index = searchInsertPosition.SearchInsert(nums, target);
            Assert.AreEqual(4, index);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 0;
            int index = searchInsertPosition.SearchInsert(nums, target);
            Assert.AreEqual(0, index);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] nums = { 1};
            int target = 0;
            int index = searchInsertPosition.SearchInsert(nums, target);
            Assert.AreEqual(0, index);
        }
    }
}
