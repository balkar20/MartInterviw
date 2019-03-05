using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Worker
    {
        public string GetArgPlusGo(string arg)
        {
            return $"{arg} + GO!";
        }

        public void ThrofIfZero(int digit)
        {
            if (digit == 0)
            {
                throw new ZeroException();
            }
        }
    }
}
