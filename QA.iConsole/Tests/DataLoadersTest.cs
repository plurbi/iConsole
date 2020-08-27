using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.iConsole.DataLoaders;
using QA.iConsole.Models.TestObjects;
using System.ComponentModel;

namespace QA.iConsole.Tests
{

    #region Proyecto automation

    //estas ya existe en el proyecto real por eso no la pongo en carpeta
    public class ComprobanteOPModel
    {
        public ComprobanteModel Comprobante { get; set; } = new ComprobanteModel();
        public int Tipo_Pago { get; set; }

    }
    public class ComprobanteModel
    {
        public int Numero_Comprobante { get; set; }
        public int ID_Comprobantes { get; set; }
    }
    #endregion

    [TestClass]
    public class DataLoadersTest
    {
        [TestMethod]
        [Category("RetencionesArgenitina")]
        [DynamicData(nameof(RetencionesDataLoader.RetencionIvaCaso1), typeof(RetencionesDataLoader), DynamicDataSourceType.Method)]
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
        [DynamicData(nameof(RetencionesDataLoader.RetencionIvaCaso2), typeof(RetencionesDataLoader), DynamicDataSourceType.Method)]
        public void DynamicData_and_Dataloaders_Example(TestDataSource_UserStory_One testData)
        {
            #region Selenium
            var op = testData.OrdenPago;
            // manipulo la UI y obtengo el/los valores a testear
            #endregion

            string loQueObtengoDeSelenium = "assert";

            Assert.AreEqual(testData.AssertRetencion, loQueObtengoDeSelenium);
        }

        [Ignore("Test ignorado por pato")]
        [TestMethod]
        [DynamicData(nameof(RetencionesDataLoader.RetencionIvaCaso1), typeof(RetencionesDataLoader), DynamicDataSourceType.Method)]
       
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
