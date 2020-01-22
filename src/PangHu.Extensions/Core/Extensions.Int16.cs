using System;

namespace System
{
    public static partial class Extensions
    {
        public static short ToInt16(this object @this)
        {
            return Convert.ToInt16(@this);
        }

        public static short ToInt16OrDefault(this object @this, short defaultValue)
        {
            try
            {
                return Convert.ToInt16(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
