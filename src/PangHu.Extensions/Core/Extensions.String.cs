using Newtonsoft.Json;
using System;

namespace System
{
    public static partial class Extensions
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string TrySerialize<T>(this T source)
        {
            return source.TrySerialize<T>(false);
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="ignoreNull"></param>
        /// <returns></returns>
        public static string TrySerialize<T>(this T source, bool ignoreNull)
        {
            var value = string.Empty;
            try
            {
                var setting = new JsonSerializerSettings()
                {
                    ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
                    DateFormatString = "yyyy-MM-dd HH:mm:ss.fffff"
                };
                if (ignoreNull)
                    setting.NullValueHandling = NullValueHandling.Ignore;

                value = JsonConvert.SerializeObject(source, setting);
            }
            catch { }
            return value;
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool TrySerialize<T>(this T source, out string value)
        {
            value = string.Empty;

            try
            {
                value = JsonConvert.SerializeObject(source);
                return true;
            }
            catch { }
            return false;
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <returns></returns>
        public static T TryDeserialize<T>(this string source, params JsonConverter[] converters)
        {
            if (string.IsNullOrWhiteSpace(source))
                return default(T);

            try
            {
                return JsonConvert.DeserializeObject<T>(source, converters);
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(this string source, out T t)
        {
            t = default(T);
            if (string.IsNullOrWhiteSpace(source))
                return false;

            try
            {
                t = JsonConvert.DeserializeObject<T>(source);
                return true;
            }
            catch { }
            return false;
        }
    }
}
