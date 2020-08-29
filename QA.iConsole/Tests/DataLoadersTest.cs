using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.iConsole.DataLoaders;
using QA.iConsole.Models.TestObjects;
using System.ComponentModel;

namespace QA.iConsole.Tests
{
    [TestClass]
    public class DataLoadersTest
    {
        [TestMethod]
        [Category("RetencionesArgenitina")]
        [DynamicData(nameof(UserStorysDataLoader.RetencionIvaCaso1), typeof(UserStorysDataLoader), DynamicDataSourceType.Method)]
        public void Retencion_Must_Be(TestDataSource_UserStory_One testData)
        {
            #region Selenium
            var op = testData.OrdenPago;
            // manipulo la UI y obtengo el/los valores a testear
            #endregion

            string loQueObtengoDeSelenium = "assert";

            Assert.AreEqual(testData.AssertRetencion, loQueObtengoDeSelenium);
        }

        [TestMethod]
        [Category("RetencionesArgenitina")]
        [DynamicData(nameof(UserStorysDataLoader.RetencionIvaCaso2), typeof(UserStorysDataLoader), DynamicDataSourceType.Method)]
        public void DynamicData_and_Dataloaders_Example(TestDataSource_UserStory_One testData)
        {
            #region Selenium
            var op = testData.OrdenPago;
            // manipulo la UI y obtengo el/los valores a testear
            #endregion

            string loQueObtengoDeSelenium = "assert";

            Assert.AreEqual(testData.AssertRetencion, loQueObtengoDeSelenium);
        }
        [TestMethod]
        [Category("RetencionesArgenitina")]
        [DynamicData(nameof(UserStorysDataLoader.DataLoadersWithPrototype), typeof(UserStorysDataLoader), DynamicDataSourceType.Method)]
        public void DynamicData_and_Dataloaders_With_Prototype_Example(TestDataSource_UserStory_One testData)
        {             
            Assert.IsTrue(testData.AssertRetencion.Length > 0);
        }
        [Ignore("Test ignorado por pato")]
        [TestMethod]
        [DynamicData(nameof(UserStorysDataLoader.RetencionIvaCaso1), typeof(UserStorysDataLoader), DynamicDataSourceType.Method)]
       
        public void Ignore_Example(TestDataSource_UserStory_One testData)
        {
            #region Selenium
            var op = testData.OrdenPago;
            // manipulo la UI y obtengo el/los valores a testear
            #endregion

            string loQueObtengoDeSelenium = "assert";

            Assert.AreEqual(testData.AssertRetencion, loQueObtengoDeSelenium);
        }
    }
}
