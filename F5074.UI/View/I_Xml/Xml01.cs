using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace F5074.UI.View.I_Xml
{
    public partial class Xml01 : UserControl
    {
        public Xml01()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            // Start with XmlReader object  
            //here, we try to setup Stream between the XML file nad xmlReader  
            using (XmlReader reader = XmlReader.Create(@".\View\I_Xml\test.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "Test":
                                if (reader.GetAttribute("Type").Contains("Label"))
                                {
                                    Console.WriteLine(reader.GetAttribute("Text"));
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}
