using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.iConsole.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.iConsole.Tests
{
    [TestClass]
    public class AssertsTests
    {
        private string stringSharedTest;

        [TestMethod]
        public void Custom_Assert_Ok()
        {
            stringSharedTest = "TEST 2!!!";
            Assert.That.ExampleExtensionAssert("TEST 2!!!", stringSharedTest);
            Debug.WriteLine(stringSharedTest);
        }
        [TestMethod]
        public void Custom_Assert_Fail()
        {
            stringSharedTest = "va a fallar!!!";
            Assert.That.ExampleExtensionAssert("fail", stringSharedTest);
            Debug.WriteLine(stringSharedTest);
        }
    }
}

