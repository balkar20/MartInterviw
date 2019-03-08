using System.Data;
using System.ServiceModel;

namespace ServerWin
{
    [ServiceContract]
    public interface IGeeter
    {

        [OperationContract]
        [FaultContract(typeof(GreetFault))]
        string Greet(string name);
    }
}