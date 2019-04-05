using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderCharDesc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCharDesc.Tests
{
    [TestClass()]
    public class UtilTests
    {
        [TestMethod()]
        public void OrderCharDescTest_Expected()
        {
            // Arrange
            string input = "abbcccddddeeeeeffffffggggghhhhiiijjk";
            string output = "ffffffeeeeegggggddddhhhhccciiibbjjak";
            // Act
            string test = Util.OrderCharDesc(input);
            // Assert
            Assert.AreEqual(test, output);
        }

        [TestMethod()]
        public void OrderCharDescTest_NullOrEmpty()
        {
            // Arrange
            string input = "";
            string output = "The input is null or empty.";
            // Act
            string test = Util.OrderCharDesc(input);
            // Assert
            Assert.AreEqual(test, output);
        }

    }
}