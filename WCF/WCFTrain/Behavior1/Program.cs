using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Behavior1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(StockService));
            foreach (ServiceEndpoint endpoint in
                serviceHost.Description.Endpoints)
                endpoint.Behaviors.Add(new MyEndpointBehavior());
            serviceHost.Open();
            // Òåïåðü ìîæíî îáðàùàòüñÿ ê ñëóæáå.
            Console.WriteLine("Ñëóæáû ãîòîâû ê ðàáîòå\n\n");
            Console.ReadLine();
            // Âûçâàòü Close äëÿ ServiceHostBase, ÷òîáû îñòàíîâèòü ñëóæáó.
            serviceHost.Close();
        }
    }
}
