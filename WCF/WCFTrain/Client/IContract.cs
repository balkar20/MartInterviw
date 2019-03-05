using System.ServiceModel;

namespace Client
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        void Say(string input);
    }
}