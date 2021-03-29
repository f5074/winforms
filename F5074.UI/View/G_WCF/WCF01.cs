using F5074.Common.Interface;
using F5074.Common.Service.WCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.UI.View.G_WCF
{
    public partial class WCF01 : UserControl
    {
        public WCF01()
        {
            InitializeComponent();
            FileUpload();
            FileDownload();
        }

        public void FileUpload()
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo("C:\\DEV\\test.pdf");
            using (System.IO.FileStream stream = new System.IO.FileStream("C:\\DEV\\test.pdf", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                WCFService<ILocalService>.getChannelFactory().UploadFile(fileInfo.Name, stream);
            }
        }

        public void FileDownload()
        {
            Stream stream = WCFService<ILocalService>.getChannelFactory().DownloadFile("test", "pdf");
        }
    }
}
