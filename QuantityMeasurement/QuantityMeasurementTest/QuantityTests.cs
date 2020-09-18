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
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 0.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.FEET, 0.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenZeroFeetToNull_WhenComparedQuantity_ThenShouldReturnNotEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 0.0);
            QuantityCompare lengthTwo = null;
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenTwoObjects_WhenCheckReference_ThenShouldReturnFalse()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 0.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.FEET, 1.0);
            bool toReturn = ReferenceEquals(lengthOne, lengthTwo);
            Assert.IsFalse(toReturn);
        }

        [TestMethod]
        public void GivenTwoObjectWithDifferentvale_Whencheckedtype_ThenShouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 0.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.FEET, 2.0);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [TestMethod]
        public void GivenZeroFeetAndFiveFeet_WhenCompareQuantity_ThenShouldReturnNotEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 0.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.FEET, 5.0);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenZeroLengthCompareAndZeroLengthCompare_WhenComparedQuantity_ThenShouldReturnEquals()
        {
            QuantityCompare LengthOne = new QuantityCompare(UnitConverter.INCH, 0.0);
            QuantityCompare LengthCompareTwo = new QuantityCompare(UnitConverter.INCH, 0.0);
            Assert.AreEqual(LengthOne, LengthCompareTwo);
        }

        [TestMethod]
        public void GivenZeroLengthCompareAndNullLengthCompare_WhenComparedQuantity_ThenShouldReturnNotEquals()
        {
            QuantityCompare LengthCompareOne = new QuantityCompare(UnitConverter.INCH, 0.0);
            QuantityCompare LengthCompareTwo = null;
            Assert.AreNotEqual(LengthCompareOne, LengthCompareTwo);
        }

        [TestMethod]
        public void GivenTwoObjectsForLengthCompare_WhenCheckedReference_ThenShouldReturnFalse()
        {
            QuantityCompare LengthCompareOne = new QuantityCompare(UnitConverter.INCH, 0.0);
            QuantityCompare LengthCompareTwo = new QuantityCompare(UnitConverter.INCH, 0.0);
            bool toReturn = ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsFalse(toReturn);
        }

        [TestMethod]
        public void GivenTwoObjectsForLengthCompare_WhenCheckedReference_ThenShouldReturnTrue()
        {
            QuantityCompare LengthCompareOne = new QuantityCompare(UnitConverter.INCH, 0.1);
            QuantityCompare LengthCompareTwo = LengthCompareOne;
            bool toReturn = ReferenceEquals(LengthCompareOne, LengthCompareTwo);
            Assert.IsTrue(toReturn);
        }

        [TestMethod]
        public void GivenTwoObjectWithDifferentvaleForLengthCompare_Whencheckedtype_ThenShouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.INCH, 0.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.INCH, 0.7);
            Assert.AreEqual(lengthOne.GetType(), lengthTwo.GetType());
        }

        [TestMethod]
        public void GivenZeroLengthCompareAndThreeLengthCompare_WhenCompareQuantity_ThenShouldReturnNotEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.INCH, 0.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.INCH, 0.3);
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenThreeLengthCompareAndThreeLengthCompare_WhenCompareQuantity_ThenShouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.INCH, 0.3);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.INCH, 0.3);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenThreeFeetAndOneYard_WhenCompareQuantity_ThenShouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 3.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenOneFeetAndOneYard_WhenCompareQuantity_ThenShouldReturnFalse()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.YARD, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenOneInchAndOneYard_WhenCompareQuantity_ThenShouldReturnFalse()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.INCH, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.YARD, 1.0);
            Assert.IsFalse(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenOneYardAnd36Inch_WhenCompareQuantity_ThenShouldReturnTrue()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.INCH, 36.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void Given36InchAndOneYard_WhenCompareQuantity_ThenShouldReturnTrue()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.INCH, 36.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenOneYardAndThreeFeet_WhenCompareQuantity_ThenShouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 3.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.YARD, 1.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void GivenTwoInchAndFiveCentimeter_WhenCompareQuantity_ThenShouldReturnTrue()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.INCH, 2.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.CENTIMETER, 5.0);
            Assert.IsTrue(lengthOne.Equals(lengthTwo));
        }

        [TestMethod]
        public void Given2InchAnd2Inch_WhenAdded_ThenshouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.INCH, 2.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.INCH, 2.0);
            QuantityCompare ExpectedInInch = new QuantityCompare(UnitConverter.INCH, 4.0);
            QuantityCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [TestMethod]
        public void Given2FeetAnd2Inch_WhenAdded_ThenShouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.INCH, 2.0);
            QuantityCompare ExpectedInInch = new QuantityCompare(UnitConverter.INCH, 14.0);
            QuantityCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [TestMethod]
        public void Given1FeetAnd1Feer_WhenAdded_ThenShouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FEET, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.FEET, 1.0);
            QuantityCompare ExpectedInInch = new QuantityCompare(UnitConverter.INCH, 24.0);
            QuantityCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [TestMethod]
        public void Given2InchtAnd24Centimeter_WhenAdded_ThenShouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.INCH, 2.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.CENTIMETER, 2.5);
            QuantityCompare ExpectedInInch = new QuantityCompare(UnitConverter.INCH, 3.0);
            QuantityCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [TestMethod]
        public void Given1gallonAndLiter_WhenComparedQuantity_ThenShouldReturnEqual()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.LITRE, 3.78);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.GALLON, 1.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void Given1LitterAnd1000milliLiter_WhenComparedQuantity_ThenShouldReturnEqual()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.LITRE, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.MILILITRE, 1000.0);
            Assert.AreEqual(lengthTwo, lengthOne);
        }

        [TestMethod]
        public void Given1GallontAndLitter_WhenAdded_ThenShouldReturnEqualsWithvalue()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.GALLON, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.LITRE, 3.78);
            QuantityCompare ExpectedInInch = new QuantityCompare(UnitConverter.LITRE, 7.56);
            QuantityCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [TestMethod]
        public void Given1LitterAnd1000MilliLiter_WhenAdded_ThenShouldReturnEqualsWithvalue2Litter()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.LITRE, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.MILILITRE, 1000.0);
            QuantityCompare ExpectedInInch = new QuantityCompare(UnitConverter.LITRE, 2);
            QuantityCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [TestMethod]
        public void Given1KilogramAnd1000Gram_WhenCompared_ThenShouldReturnEqualsWithvalue()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.KILOGRAM, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.GRAM, 1000.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void Given1TonneAnd1000Kilogram_WhenCompared_ThenShouldReturnEqualsWithvalue()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.TONNE, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.KILOGRAM, 1000.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void Given1TonneAnd1000Gram_WhenAddition_ThenShouldReturnEqualsWithvalue10001Kilogram()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.TONNE, 1.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.GRAM, 1000.0);
            QuantityCompare ExpectedInInch = new QuantityCompare(UnitConverter.KILOGRAM, 1001);
            QuantityCompare additionOfTwoLength = lengthTwo.AddLength(lengthOne);
            Assert.AreEqual(ExpectedInInch, additionOfTwoLength);
        }

        [TestMethod]
        public void Given212FahrenheitAnd100Celsius_WhenCompared_ThenShouldReturnEquals()
        {
            QuantityCompare lengthOne = new QuantityCompare(UnitConverter.FAHRENHIET, 212.0);
            QuantityCompare lengthTwo = new QuantityCompare(UnitConverter.CELCIUS, 100.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }
    }
}
