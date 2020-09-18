﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class UnitConverter
    {
        public readonly static UnitConverter FEET = new UnitConverter(12.0);
        public readonly static UnitConverter INCH = new UnitConverter(1.0);
        public readonly static UnitConverter YARD = new UnitConverter(36.0);
        public readonly static UnitConverter CENTIMETER = new UnitConverter(0.4);

        private double unitBaseConvertor;

        private UnitConverter(double unitBaseConvertor)
        {
            this.unitBaseConvertor = unitBaseConvertor;
        }

        public double ConvertedValue(double value)
        {
            return this.unitBaseConvertor * value;
        }
    }
}