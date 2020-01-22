using System;

namespace System
{
    public static partial class Extensions
    {
        public static long ToInt64(this object @this)
        {
            return Convert.ToInt64(@this);
        }

        public static long ToInt64OrDefault(this object @this, long defaultValue)
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
