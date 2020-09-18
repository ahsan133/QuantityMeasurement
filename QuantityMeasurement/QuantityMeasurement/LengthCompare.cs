using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class LengthCompare
    {
        public class LengthCompare
        {
            public enum Unit { FEET, INCH }

            private Unit unit;
            private double value;
            private double CONVERTER_INCH_FEET = 12.0;

            public LengthCompare(Unit unit, double value)
            {
                this.unit = unit;
                this.value = value;
            }

            public bool Compare(LengthCompare inchValue)
            {
                if (this.unit.Equals(inchValue.unit))
                {
                    return this.Equals(inchValue);
                }
                if (this.unit.Equals(Unit.FEET) && inchValue.unit.Equals(Unit.INCH))
                {
                    return inchValue.value.CompareTo(this.value * CONVERTER_INCH_FEET) == 0;
                }
                if (this.unit.Equals(Unit.INCH) && inchValue.unit.Equals(Unit.FEET))
                {
                    return inchValue.value.CompareTo(this.value / CONVERTER_INCH_FEET) == 0;
                }
                return false;
            }

            public override bool Equals(object obj)
            {
                if (this == obj)
                    return true;
                if (obj == null || !this.GetType().Equals(obj.GetType()))
                    return false;
                LengthCompare length = (LengthCompare)obj;
                return value.CompareTo(length.value) == 0 & unit == length.unit;
            }
        }
    }
