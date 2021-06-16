using System;

namespace Essentials.Types
{
    public static class Integer
    {
        public static int ToInt(this string text)
        {
            if (!int.TryParse(text, out int number))
                throw new FormatException($"Could not convert {text} to int");
            return number;
        }
    }
}
