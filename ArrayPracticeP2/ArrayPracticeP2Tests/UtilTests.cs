using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayPracticeP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeP2.Tests
{
    [TestClass()]
    public class UtilTests
    {
        [TestMethod()]
        public void GradingStudentsTest_Expected()
        {
            // Arrange
            int[] input = new int[] { 64, 74, 83, 92, 99 };
            int[] output = new int[] { 64, 75, 85, 92, 100 };
            // Act
            int[] result = Util.GradingStudents(input);
            // Assert - cannot compare arrays literally, so converted to strings.
            Assert.AreEqual(output.ToString(), result.ToString());
        }

        [TestMethod()]
        public void VowelCountTest_Expected()
        {
            // Arrange
            string input = "abbccdddeeee";
            int output = 5;
            // Act
            int result = Util.VowelCount(input);
            // Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod()]
        public void MaxStringTest_Expected()
        {
            string input = "Hello world, my name is Charles Philip Arthur George Mountbatten-Windsor";
            string output = "Mountbatten-Windsor";
            // Act
            string result = Util.MaxString(input);
            // Assert
            Assert.AreEqual(output, result);
        }
    }
}