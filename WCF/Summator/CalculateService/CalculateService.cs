using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculateService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculateService" in both code and config file together.
    public class CalculateService : ISummator, IMultiplicator
    {
        int ISummator.GetSum(int x, int y)
        {
            return x + y;;
        }

        int IMultiplicator.GetMul(int x, int y)
        {
            return x * y;
        }
    }
}
