﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistServe
{
    public static class Extensions
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> array)
        {
            var ret = new DataTable();
            foreach (PropertyDescriptor dp in TypeDescriptor.GetProperties(typeof(T)))
                ret.Columns.Add(dp.Name, dp.PropertyType);
            foreach (T item in array)
            {
                var Row = ret.NewRow();
                foreach (PropertyDescriptor dp in TypeDescriptor.GetProperties(typeof(T)))
                    Row[dp.Name] = dp.GetValue(item);
                ret.Rows.Add(Row);
            }
            return ret;
        }
    }
}
