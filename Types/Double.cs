using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smasgl
{
    public static class Double
    {
        public static double ToDouble(this string text)
        {
            if (!double.TryParse(text, out double number))
                throw new FormatException($"Could not convert {text} to double");
            return number;
        }
    }
}
