using System;

namespace System
{
    public static partial class Extensions
    {
        public static int ToInt32(this object @this)
        {
            return Convert.ToInt32(@this);
        }

        public static int ToInt32OrDefault(this object @this, int defaultValue)
        {
            try
            {
                return Convert.ToInt32(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
