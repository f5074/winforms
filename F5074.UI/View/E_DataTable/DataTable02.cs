using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.Common.Extension;


namespace F5074.UI.View.E_DataTable
{
    public partial class DataTable02 : UserControl
    {
        public enum GridList
        {
            PROD,
            YEAR,
            MONTH,
            QTY,
        }

        public DataTable02()
        {
            InitializeComponent();
            baseDataGridView1.DataSource = new DataTable();
            for (int rowidx = 0; rowidx < Enum.GetNames(typeof(GridList)).Length; rowidx++)
            {
                baseDataGridView1.AddColumn((GridList)rowidx);
            }
        }
    }
}
