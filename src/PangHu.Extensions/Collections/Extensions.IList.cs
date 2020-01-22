using System;
using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static partial class Extensions
    {
        /// <summary>
        /// 按元素数量切割集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">集合</param>
        /// <param name="num">每段元素数量</param>
        /// <returns>子集合列表</returns>
        public static List<List<T>> Split<T>(this List<T> source, int num = 100)
        {
            var result = new List<List<T>>();
            if (source.Count <= num)
            {
                result.Add(source);
                return result;
            }
            for (int i = 0; i < source.Count; i += num)
            {
                var newList = source.Skip(i).Take(num).ToList();
                result.Add(newList);
            }
            return result;
        }

        /// <summary>
        /// 向列表中添加多个元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">列表</param>
        /// <param name="parameters">元素</param>
        public static void Add<T>(this List<T> source, params T[] parameters) 
        {
            if (parameters == null || parameters.Length == 0)
                return;
            source.AddRange(parameters);
        }
    }
}
