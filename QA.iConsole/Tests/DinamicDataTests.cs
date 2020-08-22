using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.iConsole.DataLoaders;
using QA.iConsole.Models.TestObjects;

namespace QA.iConsole
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
    public class DinamicDataTests
    {
        #region Metodos 
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // Executes once before the test run. (Optional)
        }

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            // Executes once for the test class. (Optional)
        }

        [TestInitialize]
        public void Setup()
        {
            // Runs before each test. (Optional)
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // Executes once after the test run. (Optional)
        }

        [ClassCleanup]
        public static void TestFixtureTearDown()
        {
            // Runs once after all tests in this class are executed. (Optional)
            // Not guaranteed that it executes instantly after all tests from the class.
        }

        [TestCleanup]
        public void TearDown()
        {
            // Runs after each test. (Optional)
        }

        #endregion

        [TestMethod]
        [Category("RetencionesArgenitina")]
        [DynamicData(nameof(RetencionesDataLoader.RetencionIvaCaso1), typeof(RetencionesDataLoader), DynamicDataSourceType.Method)]
        public void Retencion_Must_Be(TestRetenciones testData)
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
        public void Retencion_Must_Be2(TestRetenciones testData)
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
        public void Retencion_Must_Be_Ignored(TestRetenciones testData)
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
