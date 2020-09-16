using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace F5074.UI.View.B_Console
{
    public partial class EnableConsole : UserControl
    {
        public EnableConsole()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void Init()
        {
           

        }

        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();

    }
}
