using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfServiceProxy;

namespace WcfServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy serviceProxy = new Proxy();
            string data = serviceProxy.getData(0);
        }
    }
}
