using System;
using CalcCononsoleClient.ServiceReference1;

namespace CalcServer
{
    public class CallbackHandler : ICalculatorDuplexCallback
    {
        public void Result(double result)
        {
            Console.WriteLine("Result({0})", result);
        }

        public void Equation(string equation)
        {
            Console.WriteLine("Equation({0}", equation);
        }
    }
}