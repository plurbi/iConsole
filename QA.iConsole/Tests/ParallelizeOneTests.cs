using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QA.iConsole.Tests
{
    [TestClass]
    public class ParallelizeOneTests : BaseTest
    {
        [TestMethod]
        public void Parallel_wait_5_secs()
        {
            Thread.Sleep(5000);
        }
        [TestMethod]
        public void Parallel_wait_10_secs()
        {
            Thread.Sleep(10000);
        }
    }
}
