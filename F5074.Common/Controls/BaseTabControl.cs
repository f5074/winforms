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
    public partial class BaseTabControl : TabControl
    {
        public BaseTabControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            ToolStripItem tsi = new ToolStripMenuItem();
            tsi.Text = "Close";
            cms.Items.Add(tsi);
            this.ContextMenuStrip = cms;
            tsi.Click += Tsi_Click;
        }

        private void Tsi_Click(object sender, EventArgs e)
        {
            this.TabPages.Clear();
        }
    }
}
