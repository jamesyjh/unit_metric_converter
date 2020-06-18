using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsWindowsConverter_1
{
    class Times
    {
        public static double MinutesToHours(double minutes)
        {
            return minutes / 60.0;
        }

        public static double HoursToMinutes(double hours)
        {
            return hours * 60.0;
        }
    }
}
