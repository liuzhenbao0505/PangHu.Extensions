using System;
using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static partial class Extensions
    {
        /// <summary>
        /// 判断集合中是否包含任一个元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">集合</param>
        /// <param name="values">元素列表</param>
        /// <returns>true:包含,false:不包含</returns>
        public static bool ContainsAny<T>(this IEnumerable<T> source, params T[] values)
        {
            T[] array = source.ToArray();
            foreach (var item in values)
            {
                if (array.Contains(item))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 判断集合中是否包含所有元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">集合</param>
        /// <param name="values">元素列表</param>
        /// <returns>true:全部包含,false:没有全部包含</returns>
        public static bool ContainsAll<T>(this IEnumerable<T> source, params T[] values)
        {
            T[] array = source.ToArray();
            foreach (var item in values)
            {
                if (!array.Contains(item))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 循环元素并执行操作方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">集合</param>
        /// <param name="action">操作方法</param>
        /// <returns>操作完成后的集合</returns>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action.Invoke(item);
            }
        }

        /// <summary>
        /// 判断集合是否为空集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">集合</param>
        /// <returns>true:是,false:否</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return !source.Any();
        }

        /// <summary>
        /// 判断集合是否不为空集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">集合</param>
        /// <returns>true：不为空,false：空</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> source)
        {
            return source.Any();
        }

        /// <summary>
        /// 判断集合是否为null或空集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">集合</param>
        /// <returns>true:是,false:否</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        /// <summary>
        /// 判断集合是否不为null或空集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">集合</param>
        /// <returns>true：不为空,false：空</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source != null && source.Any();
        }

        /// <summary>
        /// 使用分隔符连接集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">集合</param>
        /// <param name="separator">分隔符</param>
        /// <returns>字符串</returns>
        public static string StringJoin<T>(this IEnumerable<T> source, string separator)
        {
            return string.Join(separator, source);
        }

        /// <summary>
        /// 使用分隔符连接集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">集合</param>
        /// <param name="separator">分隔符</param>
        /// <returns>字符串</returns>
        public static string StringJoin<T>(this IEnumerable<T> source, char separator)
        {
            return string.Join(separator.ToString(), source);
        }
    }
}
