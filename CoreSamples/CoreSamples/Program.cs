using System;
using ClassLibrary1;
using Standart1;

namespace CoreSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.Method();
            FrameworkClass fc = new FrameworkClass();
            fc.Meth();
        }
    }
}
