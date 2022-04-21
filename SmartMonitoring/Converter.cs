using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMonitoring
{
    public static class Converter
    {
        public static List<T> DataTableToList<T>(this DataTable table) where T : new()
        {
            List<T> list = new List<T>();
            if (table != null)
            {
                var typeProperties = typeof(T).GetProperties().Select(propertyInfo => new
                {
                    PropertyInfo = propertyInfo,
                    Type = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType
                }).ToList();

                foreach (var row in table.Rows.Cast<DataRow>())
                {
                    T obj = new T();
                    foreach (var typeProperty in typeProperties)
                    {
                        if (row.Table.Columns.Contains(typeProperty.PropertyInfo.Name))
                        {
                            object value = row[typeProperty.PropertyInfo.Name];
                            object safeValue = null;
                            try
                            {
                                safeValue = value == null || DBNull.Value.Equals(value)
                                    ? null
                                    : Convert.ChangeType(value, typeProperty.Type);
                            }
                            catch (Exception ex) { }
                            typeProperty.PropertyInfo.SetValue(obj, safeValue, null);
                        }
                    }
                    list.Add(obj);
                }
            }
            return list;
        }

        public static DataTable ListToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
            TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    try
                    {
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    }
                    catch (Exception ex)
                    {
                        row[prop.Name] = null;
                    }
                }
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
