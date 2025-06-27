using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics2
{
    public class TemperatureConversionTable
    {
        public string GenerateConversionTable()
        {
            string res = "";
            for (int i = 0; i<=100; i += 5)
            {
                double farenheit = CelsiusToFahrenheit(i);
                res += i.ToString() + "\t" + $"{farenheit:F2}" + "\n";
            }
            return res;
        }

        private double CelsiusToFahrenheit(int celsius)
        {
            return (double)((celsius * 9.0 / 5.0) + 32.00);
        }
    }

}
