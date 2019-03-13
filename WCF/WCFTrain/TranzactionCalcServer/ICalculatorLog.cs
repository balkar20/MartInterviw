using System.ServiceModel;

namespace TranzactionCalcServer
{
    [ServiceContract(Namespace = "WCFTrain.TranzactionCalcServer", SessionMode = SessionMode.Required)]
    public interface ICalculatorLog
    {
        [OperationContract]
        double Add(double n1, double n2);

        [OperationContract]
        double Subtract(double n1, double n2);

        [OperationContract]
        double Multiply(double n1, double n2);

        [OperationContract]
        double Divide(double n1, double n2);
    }
}