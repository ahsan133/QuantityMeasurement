using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class LengthCompare
    {
        public class LengthCompare
        {
            public enum Unit { FEET, INCH, YARD }

            private Unit unit;
            private double value;
            private double CONVERTER_INCH_FEET = 12.0;
            private double CONVERTER_FEET_YARD = 3.0;

            public LengthCompare(Unit unit, double value)
            {
                this.unit = unit;
                this.value = value;
            }

            public bool Compare(LengthCompare inValue)
            {
                if (this.unit.Equals(inValue.unit))
                {
                    return this.Equals(inValue);
                }
                if (this.unit.Equals(Unit.FEET) && inValue.unit.Equals(Unit.INCH))
                {
                    return inValue.value.CompareTo(this.value * CONVERTER_INCH_FEET) == 0;
                }
                if (this.unit.Equals(Unit.INCH) && inValue.unit.Equals(Unit.FEET))
                {
                    return inValue.value.CompareTo(this.value / CONVERTER_INCH_FEET) == 0;
                }
                if (this.unit.Equals(Unit.FEET) && inValue.unit.Equals(Unit.YARD))
                {
                    return inValue.value.CompareTo(this.value / CONVERTER_FEET_YARD) == 0;
                }
                if (this.unit.Equals(Unit.YARD) && inValue.unit.Equals(Unit.FEET))
                {
                    return inValue.value.CompareTo(this.value * CONVERTER_FEET_YARD) == 0;
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
