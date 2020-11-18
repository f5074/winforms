using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.Common.Helper;

namespace F5074.UI.View.E_DataTable
{
    public partial class DataTable03 : UserControl
    {
        public DataTable03()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            DataTable dt = DataTableHelper.InitPivotData().Select("", string.Format("{0} DESC", "PROD")).CopyToDataTable<DataRow>();
            string groupText = "";
            int cnt = 0;
            for (int rowIdx = dt.Rows.Count -1; rowIdx >=0; rowIdx--)
            {
                string cellText = dt.Rows[rowIdx][0].ToString();
                if (groupText == "" && rowIdx != 0)
                {
                    groupText = cellText;
                    cnt++;
                }
                else if (!groupText.Equals(cellText) && !groupText.Equals(""))
                {
                    rowIdx++;
                    DataRow newRow = dt.NewRow();
                    var result = from DataList in dt.Rows.Cast<DataRow>()
                                 where DataList["PROD"].ToString() == groupText
                                 select DataList;
                    var sumQty = result.Where(row => !string.IsNullOrWhiteSpace(row["QTY"].ToString())).Sum(row => Convert.ToDecimal(row["QTY"]));
                    newRow["PROD"] = groupText;
                    newRow["QTY"] = sumQty;
                    dt.Rows.InsertAt(newRow, rowIdx);
                    groupText = "";
                    cnt = 0;
                }
                else if (rowIdx == 0)
                {
                    if (groupText == "") groupText = dt.Rows[rowIdx][0].ToString();
                    DataRow newRow = dt.NewRow();
                    var result = from DataList in dt.Rows.Cast<DataRow>()
                                 where DataList["PROD"].ToString() == groupText
                                 select DataList;
                    var sumQty = result.Where(row => !string.IsNullOrWhiteSpace(row["QTY"].ToString())).Sum(row => Convert.ToDecimal(row["QTY"]));
                    newRow["PROD"] = groupText;
                    newRow["QTY"] = sumQty;
                    dt.Rows.InsertAt(newRow, rowIdx);
                    groupText = "";
                    cnt = 0;
                }
                else
                {
                    cnt++;
                }
                this.baseDataGridView1.DataSource = dt;
            }
        }
    }
}
