using System;

namespace System
{
    public static partial class Extensions
    {
        public static bool ToBoolean(this object @this)
        {
            return Convert.ToBoolean(@this);
        }

        public static bool ToBooleanOrDefault(this object @this, bool defaultValue)
        {
            try
            {
                return Convert.ToBoolean(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
