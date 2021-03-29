using F5074.Common.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Daemon
{
    public class LocalService : ILocalService

    {
        public Stream DownloadFile(string fileName, string fileExtension)
        {
            string path = Path.GetFullPath(".\\Deploy");
            string downloadFilePath = Path.Combine(path, fileName + "." + fileExtension);

            //Write logic to create the file
            //File.Create(downloadFilePath);

            String headerInfo = "attachment; filename=" + fileName + "." + fileExtension;
            WebOperationContext.Current.OutgoingResponse.Headers["Content-Disposition"] = headerInfo;
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/octet-stream";
            return File.OpenRead(downloadFilePath);
        }

        public void UploadFile(string fileName, Stream stream)
        {
            string path = Path.GetFullPath(".\\Deploy");
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists == false) di.Create();
            string FilePath = Path.Combine(path, fileName);
            int length = 0;
            using (FileStream writer = new FileStream(FilePath, FileMode.Create))
            {
                int readCount;
                var buffer = new byte[8192];
                while ((readCount = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    writer.Write(buffer, 0, readCount);
                    length += readCount;
                }
            }
        }
    }
}
