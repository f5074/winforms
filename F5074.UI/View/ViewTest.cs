using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.UI.ViewModel;

namespace F5074.UI.View
{
    public partial class ViewTest : UserControl
    {
       private ViewTestModel vm;

        public ViewTest()
        {
            InitializeComponent();
            vm = new ViewTestModel();
            this.textBox1.DataBindings.Add("Text", vm, "status", true, DataSourceUpdateMode.OnPropertyChanged);

        }



        private void baseButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vm.status);

        }

    }
}
