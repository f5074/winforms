using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.Common.Model;

namespace F5074.Common.Controls
{
    public partial class BaseStatusBar : UserControl
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

        [Category("_Extension")]
        [Browsable(true)]
        [DisplayName("ZoomControls")]
        [Description("ZoomControls")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<ZoomComponent> ZoomControls
        {
            get
            {
                return this.zoomControl1.ZoomControls;
            }
            set
            {
                if (zoomControl1.ZoomControls != null)
                {
                }
                this.zoomControl1.ZoomControls = value;
            }
        }

        public BaseStatusBar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Bottom;
            ZoomControls = new List<ZoomComponent>();
        }
    }
}
