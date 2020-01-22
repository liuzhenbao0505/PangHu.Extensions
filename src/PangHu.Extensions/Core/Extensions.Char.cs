using System;

namespace System
{
    public static partial class Extensions
    {
        public static char ToChar(this object @this)
        {
            return Convert.ToChar(@this);
        }

        public static char ToCharOrDefault(this object @this, char defaultValue)
        {
            try
            {
                return Convert.ToChar(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
