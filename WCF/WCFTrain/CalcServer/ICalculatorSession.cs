using System.ServiceModel;

namespace CalcServer
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples", SessionMode = SessionMode.Required)]
    public interface ICalculatorSession
    {
        [OperationContract(IsOneWay = true)]
        void Clear();
        [OperationContract(IsOneWay = true)]
        void AddTo(double n);
        [OperationContract(IsOneWay = true)]
        void SubtractFrom(double n);
        [OperationContract(IsOneWay = true)]
        void MultiplyBy(double n);
        [OperationContract(IsOneWay = true)]
        void DivideBy(double n);
        [OperationContract]
        double Result();
    }
}