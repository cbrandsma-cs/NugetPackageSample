using System;

namespace PadLeft
{
    public static class StringExtensions
    {
        public static string MyPadLeft(this string text, int count)
        {
            if (text.Length < count)
            {
                return text.PadLeft(count);
            }

            return text;
        }
    }
}