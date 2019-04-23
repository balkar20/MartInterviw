using System;
using ClassLibrary1;
using Standart1;

namespace CoreSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            StandartClass1 obj = new StandartClass1();
            obj.Method();
            FrameworkClass fc = new FrameworkClass();
            fc.Meth();
        }
    }
}
