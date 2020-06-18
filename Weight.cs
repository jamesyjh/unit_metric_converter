using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsWindowsConverter_1
{
    class Weight
    {
        private static readonly double PoundsToKilogramsRatio = 0.453592;

        public static double PoundsToKilograms(double pounds)
        {
            return pounds * PoundsToKilogramsRatio;
        }

        public static double KilogramsToPounds(double kilograms)
        {
            return kilograms / PoundsToKilogramsRatio;
        }
    }
}
