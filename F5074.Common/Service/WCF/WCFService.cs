using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Service.WCF
{
    public static class WCFService<T>
    {
        public static T getChannelFactory()
        {
            ChannelFactory<T> cf = new ChannelFactory<T>(new WebHttpBinding(), "http://localhost:8000");
            cf.Endpoint.Behaviors.Add(new WebHttpBehavior());
            return cf.CreateChannel();
        }
    }
}
