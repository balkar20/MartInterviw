using System;

namespace Server
{
    public class Service : IContract
    {
        public void Say(string input)
        {
            Console.WriteLine("Message was recived - {0}", input);
        }
    }
}