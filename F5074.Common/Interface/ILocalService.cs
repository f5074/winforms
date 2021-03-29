﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Interface
{
    [ServiceContract]
    public interface ILocalService
    {
        [OperationContract]
        [WebGet(UriTemplate = "File/{fileName}/{fileExtension}")]
        Stream DownloadFile(string fileName, string fileExtension);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/UploadFile?fileName={fileName}")]
        void UploadFile(string fileName, Stream stream);
    }
}
