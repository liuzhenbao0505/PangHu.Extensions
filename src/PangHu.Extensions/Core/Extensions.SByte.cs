using System;

namespace System
{
    public static partial class Extensions
    {
        public static sbyte ToSByte(this object @this)
        {
            return Convert.ToSByte(@this);
        }

        public static sbyte ToSByteOrDefault(this object @this, sbyte defaultValue)
        {
            try
            {
                return Convert.ToSByte(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
