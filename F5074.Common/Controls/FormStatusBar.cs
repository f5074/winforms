using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Common.Controls
{
    public partial class FormStatusBar : UserControl
    {
        [Category("_Extension")]
        [Browsable(true)]
        [DisplayName("ZoomChart")]
        [Description("ZoomChart")]
        public BaseChart ZoomChart
        {
            get
            {
                return this.zoomControl1.ZoomChart;
            }
            set
            {
                if (zoomControl1.ZoomChart != null)
                {
                }
                this.zoomControl1.ZoomChart = value;
            }
        }

        public FormStatusBar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Bottom;
        }
    }
}
