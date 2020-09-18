using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class LengthCompare
    {
        public readonly UnitConverter unit;
        public readonly double value;

        public LengthCompare(UnitConverter unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            LengthCompare length = (LengthCompare)obj;
            return Double.Equals(length.unit.ConvertedValue(length.value), this.unit.ConvertedValue(this.value));
        }
    }
}
