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
        public void MaxStringTest_ReturnsLove()
        {
            //arrange
            string s = "I Love Dogs";
            //act
            string result = Util.MaxString(s);
            //assert
            Assert.AreEqual(result, "Love");
        }
    }
}