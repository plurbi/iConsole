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
    public class OrderedTests
    {
        int delay = 3000;
        [TestMethod]
        public void QA_10_Patricio()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_20_Salome()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_30_Cintia()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_15_Bibbop()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_15_Otro()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_15_AOtro()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_32_AOtro()
        {
            Thread.Sleep(delay);
        }
        [TestMethod]
        public void QA_11_AOtro()
        {
            Thread.Sleep(delay);
        }

    }
}
