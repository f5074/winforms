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
    public partial class BaseTreeView : TreeView
    {
        public BaseTreeView()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            this.ShowPlusMinus = false;
            this.ShowRootLines = false;

            ImageList il = new ImageList();
            this.ImageList = il;
            this.SelectedImageIndex = 2;
            this.BindingContextChanged += BaseTreeView_BindingContextChanged;

        }

        private void BaseTreeView_BindingContextChanged(object sender, EventArgs e)
        {
            this.ExpandAll();
        }

    }
}
