using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ServerWin
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:8004/Greet");
            WSHttpBinding binding = new WSHttpBinding();
            EndpointAddress endpoint = new EndpointAddress(uri);

            ServiceHost host = new ServiceHost(typeof(Geeter), uri);
            try
            {
                host.AddServiceEndpoint(typeof(IGeeter), binding, "Geeter");

                host.Open();
                Console.WriteLine("I Listen very match!");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                host.Abort();
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}
