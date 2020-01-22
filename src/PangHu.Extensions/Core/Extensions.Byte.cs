using System;

namespace System
{
    public static partial class Extensions
    {
        public static byte ToByte(this object @this)
        {
            return Convert.ToByte(@this);
        }

        public static byte ToByteOrDefault(this object @this, byte defaultValue)
        {
            try
            {
                return Convert.ToByte(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
