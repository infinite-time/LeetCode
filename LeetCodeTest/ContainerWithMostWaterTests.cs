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
    public class ContainerWithMostWaterTests
    {
        private readonly ContainerWithMostWater container;
        public ContainerWithMostWaterTests()
        {
            container = new ContainerWithMostWater();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int area = container.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            Assert.AreEqual(49, area);
        }
    }
}
