using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsWindowsConverter_1
{
    class Length
    {
        private readonly static double FeetToMeterRatio = 3.28084;
        public static double FeetToMeters(double feet)
        {
            return feet / FeetToMeterRatio;
        }

        public static double MetersToFeet(double meters)
        {
            return meters * FeetToMeterRatio;
        }
    }
}
