using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GrapeCity.Core
{
    public static class Helpers
    {       

        public static DataTable CreateTable<T>(this IEnumerable<T> list) where T : IModelObject
        {
            var type = typeof(T);
            var properties = type.GetProperties();

            using (var dataTable = new DataTable())
            {
                foreach (var info in properties)
                {
                    dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
                }

                foreach (var entity in list)
                {
                    var values = new object[properties.Length];
                    for (var i = 0; i < properties.Length; i++)
                    {
                        values[i] = properties[i].GetValue(entity);
                    }

                    _ = dataTable.Rows.Add(values);
                }

                return dataTable;
            }
        }
    }
}
