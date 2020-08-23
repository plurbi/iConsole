using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.iConsole.Attributes;
using QA.iConsole.DataLoaders;
using QA.iConsole.Models.TestObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.iConsole.Tests
{
    [TestClass]
    public class CustomAttributeTests
    {

        [TestMethod]
        [Category("RetencionesArgenitina")]
       // [DataTestMethod]
        [RetencionesDataSource]
        public void Attribute_DataSource_Example(TestRetenciones testData)
        {
            #region Selenium
            var op = testData.OrdenPago;
            // manipulo la UI y obtengo el/los valores a testear
            #endregion

            string loQueObtengoDeSelenium = "assert";

            Assert.AreEqual(testData.AssertRetencion, loQueObtengoDeSelenium);
        }

        [TestMethodOverride]
        public void Overriden_TestMethod_Attribute()
        {

        }
    }
}
