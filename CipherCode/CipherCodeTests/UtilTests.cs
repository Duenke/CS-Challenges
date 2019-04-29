using CipherCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherCode.Tests
{
    [TestClass()]
    public class UtilTests
    {
        [TestMethod()]
        public void CleanTest()
        {
            // Arrange
            string input1 = "We aTtack!AT_d3Awn?!?!";
            string expected = "WEATTACKATDAWN";
            // Act
            string actual = Util.Clean(input1);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleEncTest()
        {
            // Arrange
            string input1 = "WEATTACKATDAWN";
            string key = "CAT";
            string expected = "ZFUWUUFLUWEUZO";
            // Act
            string actual = Util.SimpleEnc(input1, key);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ContEncTest()
        {
            // Arrange
            string input1 = "WEATTACKATDAWN";
            string key = "CAT";
            string expected = "ZFUQYBWEBWOBQR";
            // Act
            string actual = Util.ContEnc(input1, key);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleDecTest()
        {
            // Arrange
            string input1 = "ZFUWUUFLUWEUZO";
            string key = "CAT";
            string expected = "WEATTACKATDAWN";
            // Act
            string actual = Util.SimpleDec(input1, key);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ContDecTest()
        {
            // Arrange
            string input1 = "ZFUQYBWEBWOBQR";
            string key = "CAT";
            string expected = "WEATTACKATDAWN";
            // Act
            string actual = Util.ContDec(input1, key);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}