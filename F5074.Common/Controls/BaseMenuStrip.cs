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
    public partial class BaseMenuStrip : MenuStrip
    {
        public enum ItemType
        {
            Nenu, Open, Close
        }

        public BaseMenuStrip()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            ToolStripMenuItem tsmi =  new ToolStripMenuItem(){Text = ItemType.Nenu.ToString()};
            ToolStripMenuItem otsmi = new ToolStripMenuItem() { Text = ItemType.Open.ToString() };
            ToolStripMenuItem ctsmi =  new ToolStripMenuItem(){Text = ItemType.Close.ToString()};
            this.Items.Add(tsmi);
            tsmi.DropDownItems.Add(otsmi);
            tsmi.DropDownItems.Add(ctsmi);
            tsmi.DropDownItemClicked += Tsmi_DropDownItemClicked;
        }

        void Tsmi_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Open": MessageBox.Show("Open");
                    
                    break;
            }
        }
    }
}
