using System;

namespace System
{
    public static partial class Extensions
    {
        public static uint ToUInt32(this object @this)
        {
            return Convert.ToUInt32(@this);
        }

        public static uint ToUInt32OrDefault(this object @this, uint defaultValue)
        {
            try
            {
                return Convert.ToUInt32(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
