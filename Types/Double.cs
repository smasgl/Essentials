using System;

namespace Essentials.Types
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
