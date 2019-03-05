using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculateService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculateService" in both code and config file together.
    [ServiceContract]
    public interface ISummator
    {
        [OperationContract]
        int GetSum(int x, int y);
    }

    [ServiceContract]
    public interface IMultiplicator
    {
        [OperationContract]
        int GetMul(int x, int y);
    }
}
