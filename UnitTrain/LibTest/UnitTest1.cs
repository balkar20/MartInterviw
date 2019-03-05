using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibTest
{
    [TestClass]
    public class WorkerTest
    {
        [TestMethod]
        //[ExpectedException(typeof(ZeroException), "MatherFletch")]
        public void ThrowIfZeroIfZero()
        {
            Worker worker = new Worker();
            //worker.ThrofIfZero(0);
            Assert.ThrowsException<ZeroException>(() => worker.ThrofIfZero(0));
        }

        [TestMethod]
        public void ThrowIfZeroIfNotZero()
        {
            Worker worker = new Worker();
            worker.ThrofIfZero(1);
        }
    }
}
