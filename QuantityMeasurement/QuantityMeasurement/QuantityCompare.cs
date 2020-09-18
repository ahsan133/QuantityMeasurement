using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class QuantityCompare
    {
        public readonly UnitConverter unit;
        public readonly double value;

        public QuantityCompare(UnitConverter unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public QuantityCompare AddLength(QuantityCompare that)
        {
            return new QuantityCompare(UnitConverter.INCH, this.unit.ConvertedValue(this.value) + that.unit.ConvertedValue(that.value));
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            QuantityCompare length = (QuantityCompare)obj;
            return Double.Equals(length.unit.ConvertedValue(length.value), this.unit.ConvertedValue(this.value));
        }
    }
}
