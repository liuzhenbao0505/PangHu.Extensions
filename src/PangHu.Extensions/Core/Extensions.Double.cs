using System;

namespace System
{
    public static partial class Extensions
    {
        public static double ToDouble(this object @this)
        {
            return Convert.ToDouble(@this);
        }

        public static double ToDoubleOrDefault(this object @this, double defaultValue)
        {
            try
            {
                return Convert.ToDouble(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
