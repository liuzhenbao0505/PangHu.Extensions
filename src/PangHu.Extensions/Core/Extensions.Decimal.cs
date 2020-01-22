using System;

namespace System
{
    public static partial class Extensions
    {
        public static decimal ToDecimal(this object @this)
        {
            return Convert.ToDecimal(@this);
        }

        public static decimal ToDecimalOrDefault(this object @this, decimal defaultValue)
        {
            try
            {
                return Convert.ToDecimal(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
