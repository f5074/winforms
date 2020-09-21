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
    public partial class DataTable01 : UserControl
    {
        public DataTable01()
        {
            InitializeComponent();

            this.baseDataGridView1.DataSource = DataTableHelper.InitPivotData();
        }
    }
}
