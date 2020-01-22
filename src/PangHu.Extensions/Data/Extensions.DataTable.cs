using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace System
{
    public static partial class Extensions
    {
        public static IEnumerable<T> ToEntities<T>(this DataTable source) where T : new()
        {
            Type type = typeof(T);
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<T>();

            foreach (DataRow dr in source.Rows)
            {
                var entity = new T();

                foreach (var property in properties)
                {
                    if (source.Columns.Contains(property.Name))
                    {
                        property.SetValue(entity, dr[property.Name].To(property.PropertyType), null);
                    }
                }

                foreach (var field in fields)
                {
                    if (source.Columns.Contains(field.Name))
                    {
                        field.SetValue(entity, dr[field.Name].To(field.FieldType));
                    }
                }

                list.Add(entity);
            }

            return list;
        }
    }
}
