using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QA.iConsole
{
    public class TestRetenciones
    {
        public ComprobanteOPModel OrdenPago { get; set; }
        public string RetencionEsperada { get; set; }
    }
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

    [TestClass]
    public class RetencionesArgentina
    {

        [TestMethod]
        // La declaracion del objeto debe estar en la misma clase
        //[DynamicData("RetencionIvaCaso1", DynamicDataSourceType.Method)]
        //[DynamicData("RetencionIvaCaso2", DynamicDataSourceType.Method)]
        // En una clase static
        [DynamicData(nameof(RetencionesDataLoader.RetencionIvaCaso1), typeof(RetencionesDataLoader), DynamicDataSourceType.Method)]
        [DynamicData(nameof(RetencionesDataLoader.RetencionIvaCaso2), typeof(RetencionesDataLoader), DynamicDataSourceType.Method)]

        public void Retencion_Must_Be(TestRetenciones opModel)
        {
            #region Selenium

            #endregion

            Assert.AreEqual(opModel.RetencionEsperada, "loquedevuelvaselenium");
        }
    }

    public static class RetencionesDataLoader
    {
        public static IEnumerable<TestRetenciones[]> RetencionIvaCaso1()
        {
            return new[]
            {
                   new TestRetenciones[]
                   {
                      new TestRetenciones()
                      {
                           OrdenPago  = new ComprobanteOPModel()
                            {
                                Comprobante = new ComprobanteModel
                                {
                                    Numero_Comprobante = 1,
                                    ID_Comprobantes = 1
                                }                                                        ,
                                Tipo_Pago = 2
                            },
                           RetencionEsperada = "loquedevuelvaselenium"
                      }
                   }
            };
        }
        public static IEnumerable<TestRetenciones[]> RetencionIvaCaso2()
        {
            return new[]
            {
                   new TestRetenciones[]
                   {
                      new TestRetenciones()
                      {
                           OrdenPago  =   new ComprobanteOPModel()
                            {
                                Comprobante =  new ComprobanteModel
                                {
                                    Numero_Comprobante = 1,
                                    ID_Comprobantes = 1
                                }                                                        ,
                                Tipo_Pago = 2
                            },
                           RetencionEsperada = "loquedevuelvaselenium-fail"
                      }
                   }
            };
        }
    }
}
