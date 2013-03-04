using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfServiceProxy.WcfServiceReference;

namespace WcfServiceProxy
{
    public class Proxy
    {
        public string getData(int arg)
        {
            Service1Client client = new Service1Client();
            return client.GetData(arg);

        }
    }
}
