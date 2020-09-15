using Microsoft.VisualStudio.TestTools.UnitTesting;
using CupsToOuncesBrady;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CupsToOuncesBrady.Tests
{
    [TestClass()]
    public class CupsToOuncesFormTests
    {
        [TestMethod()]
        public void btnConvert_ClickTest() //Test 1
        {
            //Arrange
            double expected = 24; //24 ounces expected for 3 cups
            double cupsEntered = 3; //cups entered is 3

            //Act
            CupsToOuncesForm newCups = new CupsToOuncesForm(); //creates instance of CupsToOunces class
            double result = newCups.CupsToOunces(cupsEntered); //calls CupsToOunces method and passes 3 cups as argument

            //Assert
            Assert.AreEqual(expected, result); //asserts that expected and result are equal
        }

        [TestMethod()]
        public void btnConvert_ClickTest2() //Test 2
        {
            //Arrange
            double expected = 4; //4 ounces expected for 0.5 cup
            double cupsEntered = 0.5; //cups entered is 0.5

            //Act
            CupsToOuncesForm newCups = new CupsToOuncesForm(); //creates instance of CupsToOunces class
            double result = newCups.CupsToOunces(cupsEntered); //calls CupsToOunces method and passes 0.5 cup as argument

            //Assert
            Assert.AreEqual(expected, result); //asserts that expected and result are equal
        }

        [TestMethod()]
        public void btnConvert_ClickTest3() //Test 3
        {
            //Arrange
            double expected = ((0.33) * 8); //(0.33 * 8) ounces expected for 0.33 cup
            double cupsEntered = 0.33; //cups entered is 0.33

            //Act
            CupsToOuncesForm newCups = new CupsToOuncesForm(); //creates instance of CupsToOunces class
            double result = newCups.CupsToOunces(cupsEntered); //calls CupsToOunces method and passes 0.33 cup as argument

            //Assert
            Assert.AreEqual(expected, result, 0.00); //asserts that expected and result are equal
        }

        [TestMethod()]
        public void btnConvert_ClickTest4() //Tests NEGATIVE value
        {
            //Arrange
            double cupsEntered = -3; //cups entered is -3
            double cupsExpected = 24; //cups expected is 24, not -24

            //Act
            CupsToOuncesForm newCups = new CupsToOuncesForm(); //creates instance of CupsToOunces class
            double result = newCups.CupsToOunces(cupsEntered);

            //Assert
            Assert.AreNotEqual(result, cupsExpected); //asserts that values are not equal, due to invalid input
        }
    }
}