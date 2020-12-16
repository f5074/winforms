using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.Common.Controls;

namespace F5074.Common.Extension
{
    public static class DataGridViewExtension
    {
        /// <summary>
        /// AddColumn
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="view"></param>
        /// <param name="eVal"></param>
        public static void AddColumn<TEnum>(this BaseDataGridView view , TEnum eVal)where TEnum : struct, IConvertible, IComparable, IFormattable
        {
            DataTable dt = (DataTable)view.DataSource;
            dt.Columns.Add(new DataColumn(eVal.ToString(), typeof(string)));
            view.DataSource = dt;
        }

        /// <summary>
        /// AddColumn
        /// </summary>
        /// <param name="view"></param>
        /// <param name="eVal"></param>
        public static void AddColumn(this BaseDataGridView view, Enum eVal, bool isEnum)
        {
            DataTable dt = (DataTable)view.DataSource;
            dt.Columns.Add(new DataColumn(eVal.ToCaption(), typeof(string)));
            view.DataSource = dt;
        }
    }
}
