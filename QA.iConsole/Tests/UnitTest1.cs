﻿using System;
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
    }
}
