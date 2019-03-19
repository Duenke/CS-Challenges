using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thermometer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermometer.Tests
{
    [TestClass()]
    public class Form1Tests : Form1
    {
        [TestMethod()]
        public void ChangeTempTest()
        {
            //Arrange
            double far = Form1.vScrollBar1.Value;
            double centi = (far - 32) * (5 / 9);

            //Act
            label4.Text = centi.ToString();
            label3.Text = far.ToString();

            //Assert
            Assert.Fail();
        }
    }
}