using System;

namespace System
{
    public static partial class Extensions
    {
        public static ushort ToUInt16(this object @this)
        {
            return Convert.ToUInt16(@this);
        }

        public static ushort ToUInt16OrDefault(this object @this, ushort defaultValue)
        {
            try
            {
                return Convert.ToUInt16(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
