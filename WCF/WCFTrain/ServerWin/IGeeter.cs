using System.Data;
using System.ServiceModel;

namespace ServerWin
{
    [ServiceContract]
    public interface IGeeter
    {
        [OperationContract]
        string Greet(string name);
    }
}