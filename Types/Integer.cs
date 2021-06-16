using System;

namespace Essentials.Types
{
    public static class Integer
    {
        public static int ToInt(this string text)
        {
            if (!int.TryParse(text, out int integer))
                throw new FormatException($"Could not convert {text} to integer");
            return integer;
        }
    }
}
