using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Common.Helper
{
    public class OleDbHelper
    {
        public void InitOleDb()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            if (ofd.ShowDialog() != null) return;
            string extension = Path.GetExtension(ofd.FileName);
            string connectionString = "";
            string excelString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= {0};Extended Properties=\"Excel 8.0; Imex=2; HDR=Yes;\"";
            connectionString = string.Format(excelString, ofd.FileName);

            List<string> list = new List<string>();
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                using (OleDbCommand oc = new OleDbCommand())
                {
                    oc.Connection = con;
                    con.Open();
                    DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        list.Add(dt.Rows[x]["TABLE_NAME"] as string);
                    }
                    con.Close();
                }
            }
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                using (OleDbCommand oc = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        oc.CommandText = string.Format("SELECT * FROM[{0}]", list[0]);
                        oc.Connection = con;
                        con.Open();
                        oda.SelectCommand = oc;
                        oda.Fill(new DataTable());
                        con.Close();
                    }
                }
            }
        }
    }
}
