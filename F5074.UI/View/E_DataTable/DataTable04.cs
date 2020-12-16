using F5074.Common.Annotations;
using F5074.Common.Extension;
using F5074.Common.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.UI.View.E_DataTable {
    public partial class DataTable04 : UserControl {

        public enum BaseGrid {
            [Caption("생산품"), Width(100)]PROD,
            [Caption("년도"), Width(100)] YEAR,
            [Caption("월"), Width(100)] MONTH,
            [Caption("수량"), Width(100)] QTY,
        }
        public DataTable04()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            baseDataGridView1.DataSource = new DataTable();
            for (int columnIdx = 0; columnIdx < Enum.GetNames(typeof(BaseGrid)).Length; columnIdx++)
            {
                baseDataGridView1.AddColumn((BaseGrid)columnIdx, true);
            }
        }
    }
}
