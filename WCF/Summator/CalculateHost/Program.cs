using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(CalculateService.CalculateService)))
            {
                host.Open();

                Console.WriteLine("Host started....");
                Console.ReadLine();
            }
        }
    }
}
