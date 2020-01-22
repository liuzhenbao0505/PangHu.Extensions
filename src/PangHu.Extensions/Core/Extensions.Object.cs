using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace System
{
    public static partial class Extensions
    {
        /// <summary>
        /// 将对象转换为目标类型的对象
        /// </summary>
        /// <param name="source">源对象</param>
        /// <param name="targetType">目标类型</param>
        /// <returns>目标类型对象</returns>
        public static object To(this object source, Type targetType)
        {
            if (source == DBNull.Value)
                return null;

            if (source.GetType() == targetType)
                return source;

            var converter = TypeDescriptor.GetConverter(source);
            if (converter != null)
            {
                if (converter.CanConvertTo(targetType))
                    return converter.ConvertTo(source, targetType);
            }

            converter = TypeDescriptor.GetConverter(targetType);
            if (converter != null)
            {
                if (converter.CanConvertFrom(source.GetType()))
                    return converter.ConvertFrom(source);
            }

            return source;
        }

        /// <summary>
        /// 将对象转换为目标类型的对象
        /// </summary>
        /// <param name="source">源对象</param>
        /// <returns>目标类型对象</returns>
        public static T To<T>(this object source)
        {
            if (source == DBNull.Value)
                return (T)(object)null;

            var targetType = typeof(T);
            if (source.GetType() == targetType)
                return (T)source;

            var converter = TypeDescriptor.GetConverter(source);
            if (converter != null)
            {
                if (converter.CanConvertTo(targetType))
                    return (T)converter.ConvertTo(source, targetType);
            }

            converter = TypeDescriptor.GetConverter(targetType);
            if (converter != null)
            {
                if (converter.CanConvertFrom(source.GetType()))
                    return (T)converter.ConvertFrom(source);
            }

            return (T)source;
        }

        /// <summary>
        /// 获取对象的属性字段列表
        /// </summary>
        /// <param name="source">对象</param>
        /// <returns>字段列表</returns>
        public static List<string> ToFields(this object source)
        {
            if (source == null)
                return null;

            if (source is System.Collections.IEnumerable)
                return null;

            var type = source.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<string>();
            if (properties != null)
            {
                foreach (var item in properties)
                {
                    list.Add(item.Name);
                }
            }

            if (fields != null)
            {
                foreach (var item in fields)
                {
                    list.Add(item.Name);
                }
            }

            return list;
        }

        public static Dictionary<string, object> ToValues(this object source)
        {
            if (source == null)
                return null;

            if (source is System.Collections.IEnumerable)
                return null;

            var type = source.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var result = new Dictionary<string, object>();
            if (properties != null)
            {
                foreach (var item in properties)
                {
                    result.Add(item.Name, item.GetValue(source, null));
                }
            }

            if (fields != null)
            {
                foreach (var item in fields)
                {
                    result.Add(item.Name, item.GetValue(source));
                }
            }

            return result;
        }
    }
}
