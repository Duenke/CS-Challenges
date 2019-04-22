using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Tests
{
    [TestClass()]
    public class UtilTests
    {
        [TestMethod()]
        public void SelectSortTest()
        {
            // Arrange
            int[] test = { 8, 4, 2, 9, 3, 6, 5, 5, 1, 10 };
            int[] expected = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10 };

            int[] test2 = { 866, 761, 92, 687, 156, 254, 863, 7456 };
            int[] expected2 = { 92, 156, 254, 687, 761, 863, 866, 7456 };
            // Act
            int[] actual = Util.SelectSort(test);
            int[] actual2 = Util.SelectSort(test2);
            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());
        }
    }
}