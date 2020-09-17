using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace F5074.UI.View.D_Serialization
{
    public partial class NormalSerialize : UserControl
    {
        public NormalSerialize()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            SerialTestVo[] vo = new SerialTestVo[]{
                new SerialTestVo(){ID= 1, Name = ".Net"},
                new SerialTestVo(){ID= 2, Name = ".Net"},
                new SerialTestVo(){ID= 3, Name = ".Net"},
            };

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\osryu\Desktop\winforms-master\winforms-master\Test.txt", FileMode.Create, FileAccess.Write);
            var serializer = new DataContractJsonSerializer(typeof(SerialTestVo[]), new[] { typeof(SerialTestVo[]) }, Int32.MaxValue, true, null, false);
            serializer.WriteObject(stream, vo);
            //formatter.Serialize(stream, vo);
            stream.Close();
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\osryu\Desktop\winforms-master\winforms-master\Test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);
            var serializer = new DataContractJsonSerializer(typeof(SerialTestVo[]), new[] { typeof(SerialTestVo[]) }, Int32.MaxValue, true, null, false);
            SerialTestVo[] arrVo = serializer.ReadObject(stream) as SerialTestVo[];
            stream.Close();
            for (int x = 0; x < arrVo.Length; x++)
            {
                Console.WriteLine(string.Join(" ", arrVo[x].ID, arrVo[x].Name));
            }
        }

    }
}
