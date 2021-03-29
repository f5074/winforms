using F5074.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Daemon
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(LocalService), new Uri("http://localhost:8000/"));
            try
            {
                ServiceEndpoint ep = host.AddServiceEndpoint(typeof(ILocalService), new WebHttpBinding(), "");
                host.Open();
                using (ChannelFactory<ILocalService> cf = new ChannelFactory<ILocalService>(new WebHttpBinding(), "http://localhost:8000"))
                {
                    cf.Endpoint.Behaviors.Add(new WebHttpBehavior());

                    ILocalService channel = cf.CreateChannel();
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo("C:\\DEV\\test.pdf");
                    using (System.IO.FileStream stream =
                           new System.IO.FileStream("C:\\DEV\\test.pdf", System.IO.FileMode.Open, System.IO.FileAccess.Read))

                        channel.UploadFile(fileInfo.Name, stream);
                }
                Console.WriteLine("Press <ENTER> to terminate");
                Console.ReadLine();

                host.Close();
            }
            catch (CommunicationException cex)
            {
                Console.WriteLine("An exception occurred: {0}", cex.Message);
                host.Abort();
            }
        }
    }
}
