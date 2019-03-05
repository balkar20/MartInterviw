using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";
            Uri adress = new Uri("http://localhost:4000/IContract");

            BasicHttpBinding binding = new BasicHttpBinding();

            EndpointAddress endpoint = new EndpointAddress(adress);

            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding, endpoint);

            IContract channel = factory.CreateChannel();

            channel.Say("Hello wcf!");

            Console.ReadKey();
        }
    }
}
