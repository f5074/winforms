using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace F5074.UI.View.H_Resource
{
    public partial class Resource01 : UserControl
    {
        CultureInfo culture;

        public Resource01()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            culture = CultureInfo.CreateSpecificCulture("en-US");
            ResourceManager rm = new ResourceManager("F5074.UI.View.H_Resource.ResourceFile", Assembly.GetExecutingAssembly());
            String strWebsite = rm.GetString("Website", culture);
            String strName = rm.GetString("Name", culture);
            Console.WriteLine("Website: " + strWebsite + "--Name: " + strName);
        }

    }
}
