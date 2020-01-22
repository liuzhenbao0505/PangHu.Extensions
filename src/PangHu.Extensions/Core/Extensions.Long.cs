using System;

namespace System
{
    public static partial class Extensions
    {
        public static long ToLong(this object @this)
        {
            return Convert.ToInt64(@this);
        }

        public static long ToLongOrDefault(this object @this, long defaultValue)
        {
            try
            {
                return Convert.ToInt64(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
