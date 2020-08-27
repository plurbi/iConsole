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
    public class OrderedByMSTests
    {
        int delay = 3000;
        [TestMethod]
        public void QA_10_One()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_20_Two()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_30_Three()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_15_Four()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_15_Five()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_15_Six()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_32_Seven()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_11_Eight()
        {
            Thread.Sleep(delay);
        }

    }
}
