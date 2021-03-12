using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public class DegreeConverter
    {
        public double ToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        public double ToCelsius(double fahrenheit)
        {
            return (32 * fahrenheit - 32) * 5 / 9;
        }

    }
}
