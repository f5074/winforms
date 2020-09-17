using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.UI.View.C_DateTime
{
    public partial class DateTIme01 : UserControl
    {
        public DateTIme01()
        {
            InitializeComponent();


            string a = "2019-11-26 00:00:00";

            Console.WriteLine(a);
            string b = Convert.ToDateTime(a).ToString("yyyy-MM-dd");
            Console.WriteLine(b);

            DateTime dtMinDate = DateTime.ParseExact(b, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dtMinDate.ToString());

            string c = DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd");
            Console.WriteLine(c);
        }

    }
}
