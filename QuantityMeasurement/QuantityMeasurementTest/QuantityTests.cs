using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuantityMeasurement;

namespace QuantityMeasurementTest
{
    [TestClass]
    public class QuantityTests
    {
        [TestMethod]
        public void GivenZeroFeetToZeroFeet_WhenComparedQuantity_ThenShouldReturnEqual()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.FEET, 0.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenZeroFeetToNull_WhenComparedQuantity_ThenShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.FEET, 0.0);
            LengthCompare lengthTwo = null;
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenTwoObjects_WhenCheckReference_ThenShouldReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.FEET, 1.0);
            bool toReturn = ReferenceEquals(lengthOne, lengthTwo);
            Assert.IsFalse(toReturn);
        }

        [TestMethod]
        public void GivenTwoObjectWithDifferentvale_Whencheckedtype_ThenShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.FEET, 2.0);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [TestMethod]
        public void GivenZeroFeetAndFiveFeet_WhenCompareQuantity_ThenShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.FEET, 5.0);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenZeroLengthCompareAndZeroLengthCompare_WhenComparedQuantity_ThenShouldReturnEquals()
        {
            LengthCompare LengthOne = new LengthCompare(UnitConverter.INCH, 0.0);
            LengthCompare LengthCompareTwo = new LengthCompare(UnitConverter.INCH, 0.0);
            Assert.AreEqual(LengthOne, LengthCompareTwo);
        }

        [TestMethod]
        public void GivenZeroLengthCompareAndNullLengthCompare_WhenComparedQuantity_ThenShouldReturnNotEquals()
        {
            LengthCompare LengthCompareOne = new LengthCompare(UnitConverter.INCH, 0.0);
            LengthCompare LengthCompareTwo = null;
            Assert.AreNotEqual(LengthCompareOne, LengthCompareTwo);
        }

        [TestMethod]
        public void GivenTwoObjectsForLengthCompare_WhenCheckedReference_ThenShouldReturnFalse()
        {
            LengthCompare LengthCompareOne = new LengthCompare(UnitConverter.INCH, 0.0);
            LengthCompare LengthCompareTwo = new LengthCompare(UnitConverter.INCH, 0.0);
            bool toReturn = ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsFalse(toReturn);
        }

        [TestMethod]
        public void GivenTwoObjectsForLengthCompare_WhenCheckedReference_ThenShouldReturnTrue()
        {
            LengthCompare LengthCompareOne = new LengthCompare(UnitConverter.INCH, 0.1);
            LengthCompare LengthCompareTwo = LengthCompareOne;
            bool toReturn = ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsTrue(toReturn);
        }

        [TestMethod]
        public void GivenTwoObjectWithDifferentvaleForLengthCompare_Whencheckedtype_ThenShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.INCH, 0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.INCH, 0.7);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [TestMethod]
        public void GivenZeroLengthCompareAndThreeLengthCompare_WhenCompareQuantity_ThenShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.INCH, 0.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.INCH, 0.3);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenThreeLengthCompareAndThreeLengthCompare_WhenCompareQuantity_ThenShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.INCH, 0.3);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.INCH, 0.3);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenThreeFeetAndOneYard_WhenCompareQuantity_ThenShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.FEET, 3.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenOneFeetAndOneYard_WhenCompareQuantity_ThenShouldReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.FEET, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.YARD, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenOneInchAndOneYard_WhenCompareQuantity_ThenShouldReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.INCH, 1.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.YARD, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenOneYardAnd36Inch_WhenCompareQuantity_ThenShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.INCH, 36.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void Given36InchAndOneYard_WhenCompareQuantity_ThenShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.INCH, 36.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenOneYardAndThreeFeet_WhenCompareQuantity_ThenShouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.FEET, 3.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenTwoInchAndFiveCentimeter_WhenCompareQuantity_ThenShouldReturnTrue()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.INCH, 2.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.CENTIMETER, 5.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void Given2InchAnd2Inch_ThenAddition_shouldReturnEquals()
        {
            LengthCompare lengthOne = new LengthCompare(UnitConverter.INCH, 2.0);
            LengthCompare lengthTwo = new LengthCompare(UnitConverter.INCH, 2.0);
            LengthCompare ExpectedInInch = new LengthCompare(UnitConverter.INCH, 4.0);
            LengthCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }
    }
}
