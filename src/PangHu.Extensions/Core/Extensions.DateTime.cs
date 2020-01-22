using System;

namespace System
{
    public static partial class Extensions
    {
        public static DateTime ToDateTime(this object @this)
        {
            return Convert.ToDateTime(@this);
        }

        public static DateTime ToDateTimeOrDefault(this object @this, DateTime defaultValue)
        {
            try
            {
                return Convert.ToDateTime(@this);
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 格式化时间
        /// </summary>
        /// <param name="this">时间</param>
        /// <param name="format">格式</param>
        /// <returns></returns>
        public static string ToFormat(this DateTime @this, string format = "yyyy-MM-dd HH:mm:ss")
        {
            return @this.ToString(format);
        }

        /// <summary>
        /// 判断时间是否在一段时间范围内
        /// </summary>
        /// <param name="this">时间</param>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <returns>true:在范围内，false:不在范围内</returns>
        public static bool IsBetween(this DateTime @this, DateTime startTime, DateTime endTime)
        {
            return @this >= startTime && @this <= endTime;
        }

        /// <summary>
        /// 获取上个月一号日期
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DateTime ToLastMonthDate(this DateTime @this)
        {
            return @this.Date.AddDays(1 - @this.Day).AddMonths(-1);
        }

        /// <summary>
        /// 获取当前月一号日期
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DateTime ToThisMonthDate(this DateTime @this)
        {
            return @this.Date.AddDays(1 - @this.Day);
        }

        /// <summary>
        /// 获取上周一日期
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DateTime ToLastWeekDate(this DateTime @this)
        {
            int day = (int)@this.DayOfWeek;
            if (day == 0) day = 7;
            return @this.Date.AddDays(1 - day - 7);
        }

        /// <summary>
        /// 获取本周一日期
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DateTime ToThisWeekDate(this DateTime @this)
        {
            int day = (int)@this.DayOfWeek;
            if (day == 0) day = 7;
            return @this.Date.AddDays(1 - day);
        }

        /// <summary>
        /// 获取昨天日期
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DateTime ToYesterdayDate(this DateTime @this)
        {
            return @this.Date.AddDays(-1);
        }

        /// <summary>
        /// 获取前天日期
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DateTime ToBeforeYesterdayDate(this DateTime @this)
        {
            return @this.Date.AddDays(-2);
        }
    }
}
