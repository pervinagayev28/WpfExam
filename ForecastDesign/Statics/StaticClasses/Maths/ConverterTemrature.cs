using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastDesign.Statics.StaticClasses.Maths
{
    public static class ConverterTemrature
    {
        public static float ConvertToFarenheit(float celsius) =>
                 (celsius * 9 / 5) + 32;
        public static float ConvertToCelsius(float fahrenheit) =>
                (fahrenheit - 32) * 5 / 9;

        internal static object ConvertToCelsius(object temp)
        {
            throw new NotImplementedException();
        }
    }
}
