using System;
using System.ServiceModel;

namespace ServerWin
{
    public class Geeter : IGeeter
    {
        
        public string Greet(string name)
        {
            if (string.Compare(name, "fex") == 0)
            {
                throw new FaultException<GreetFault>(new GreetFault("OOoo - your exception is valid: "));
            }
            if (string.Compare(name, "ufex") == 0)
            {
                throw new FaultException("Your unnown exception is valid for me");
            }
            if (string.Compare(name, "dex") == 0)
            {
                throw new Exception("Why you wannt exception?");
            }
            if(string.Compare(name, "dex") == 0)
            {
                throw new Exception("Why you wannt exception?");
            }

            return $"Fuck you {name}";
        }
    }
}