using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Helper
{
    public static class DataTableHelper
    {
        public static DataTable InitPivotData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PROD", typeof(string));
            dt.Columns.Add("QTY", typeof(string));
            dt.Columns.Add("YEAR", typeof(string));
            dt.Columns.Add("MONTH", typeof(string));

            dt.Rows.Add("AAA01", 100, "2020", "09");
            dt.Rows.Add("AAA02", 100, "2020", "09");
            dt.Rows.Add("AAA03", 100, "2020", "09");
            dt.Rows.Add("AAA04", 100, "2020", "09");
            dt.Rows.Add("AAA05", 100, "2020", "09");
            dt.Rows.Add("AAA06", 100, "2020", "08");
            dt.Rows.Add("AAA07", 100, "2020", "08");
            dt.Rows.Add("AAA08", 100, "2020", "08");
            dt.Rows.Add("AAA09", 100, "2020", "08");
            return dt;
        }

        public static DataTable ComputeDataTable()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Data";
            dt.Columns.Add("CODE", typeof(string));
            dt.Columns.Add("NAME", typeof(string));
            dt.Rows.Add(new object[] { "A", "All" });
            dt.Rows.Add(new object[] { "B", "All" });
            dt.Compute("Count(CODE)", "CODE = 'B'");
            return dt;
        }
    }
}
