using System.ServiceModel;

namespace CalcServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CalculatorService : ICalculatorDuplex
    {
        double result = 0.0D;
        string equation;

        public CalculatorService()
        {
            equation = result.ToString();
        }

        public void Clear()
        {
            Callback.Equation(equation + " = " + result.ToString());
            equation = result.ToString();
        }

        public void AddTo(double n)
        {
            result += n;
            equation += " + " + n.ToString();
            Callback.Result(result);
        }

        public void SubtractFrom(double n)
        {
            result -= n;
            Callback.Result(result);
        }

        public void MultiplyBy(double n)
        {
            result *= n;
            Callback.Result(result);
        }

        public void DivideBy(double n)
        {
            result = result / n;
            Callback.Result(result);
        }

        //...  

        ICalculatorDuplexCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<ICalculatorDuplexCallback>();
            }
        }
    }
}