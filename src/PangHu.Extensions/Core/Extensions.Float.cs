using System;

namespace System
{
    public static partial class Extensions
    {
        public static float ToFloat(this object @this)
        {
            return Convert.ToSingle(@this);
        }

        public static float ToFloatOrDefault(this object @this, float defaultValue)
        {
            try
            {
                return Convert.ToSingle(@this);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
