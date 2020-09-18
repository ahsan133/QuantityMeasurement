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
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(LengthCompare.Unit.FEET, 0.0);
            Assert.AreEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenZeroFeetToNull_WhenComparedQuantity_ThenShouldReturnNotEquals()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.FEET, 0.0);
            LengthCompare lengthTwo = null;
            Assert.AreNotEqual(lengthOne, lengthTwo);
        }

        [TestMethod]
        public void GivenTwoObjects_WhenCheckReference_ThenShouldReturnFalse()
        {
            LengthCompare lengthOne = new LengthCompare(LengthCompare.Unit.FEET, 0.0);
            LengthCompare lengthTwo = new LengthCompare(LengthCompare.Unit.FEET, 1.0);
            bool toReturn = System.Object.ReferenceEquals(lengthOne, lengthTwo);
            Assert.IsFalse(toReturn);
        }
    }
}
