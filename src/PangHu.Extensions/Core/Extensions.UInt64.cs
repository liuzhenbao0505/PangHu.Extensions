using System;

namespace System
{
    public static partial class Extensions
    {
        public static ulong ToUInt64(this object @this)
        {
            return Convert.ToUInt64(@this);
        }

        public static ulong ToUInt64OrDefault(this object @this, ulong defaultValue)
        {
            try
            {
                return Convert.ToUInt64(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
