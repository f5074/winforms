using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.Common.Controls;

namespace F5074.UI.View.A_Zoom
{
    public partial class ZoomForm : UserControl
    {
        public ZoomForm()
        {
            InitializeComponent();
            //BasePanel bp = this.baseChart1.Parent as BasePanel;
            //BasePanel bp = new BasePanel();
            //bp.Dock = DockStyle.Fill;
            //this.baseChart1.Parent = bp;
            //bp.BackColor = Color.Silver;
            //bp.AutoScroll = true;


            this.Load += ZoomForm_Load;
        }

        void ZoomForm_Load(object sender, EventArgs e)
        {
            this.basePanel1.AutoScroll = true;
            formStatusBar1.ZoomChart = this.baseChart1;
            this.baseChart1.Dock = DockStyle.Left;
        }
    }
}
