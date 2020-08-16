using System;
using System.Collections.Generic;
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
    public class RetencionesArgentina
    {

        [TestMethod]
        // La declaracion del objeto debe estar en la misma clase
        //[DynamicData("RetencionIvaCaso1", DynamicDataSourceType.Method)]
        //[DynamicData("RetencionIvaCaso2", DynamicDataSourceType.Method)]
        // En una clase static     
        [DynamicData(nameof(RetencionesDataLoader.RetencionIvaCaso1), typeof(RetencionesDataLoader), DynamicDataSourceType.Method)]
        public void Retencion_Must_Be(TestRetenciones opModel)
        {
            #region Selenium

            #endregion

            string loQueObtengoDeSelenium = "assert";

            Assert.AreEqual(opModel.AssertRetencion, loQueObtengoDeSelenium);
        }
    }

    
}
