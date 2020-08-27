using QA.iConsole.Models.TestObjects;
using QA.iConsole.Tests;
using System.Collections.Generic;

namespace QA.iConsole.DataLoaders
{
    public static class RetencionesDataLoader
    {
        public static IEnumerable<TestDataSource_UserStory_One[]> RetencionIvaCaso1()
        {
            TestDataSource_UserStory_One testRetencionesParams = new TestDataSource_UserStory_One()
            {
                OrdenPago = new ComprobanteOPModel()
                {
                    Comprobante = new ComprobanteModel
                    {
                        Numero_Comprobante = 1,
                        ID_Comprobantes = 1
                        
                    },
                    
                    Tipo_Pago = 2
                },
                AssertRetencion = "assert"
            };
            TestDataSource_UserStory_One testRetencionesParams2 = new TestDataSource_UserStory_One()
            {
                OrdenPago = new ComprobanteOPModel()
                {
                    Comprobante = new ComprobanteModel
                    {
                        Numero_Comprobante = 1,
                        ID_Comprobantes = 1
                    },
                    Tipo_Pago = 2
                },
                AssertRetencion = "assert"
            };
            TestDataSource_UserStory_One testRetencionesParams3 = new TestDataSource_UserStory_One()
            {
                OrdenPago = new ComprobanteOPModel()
                {
                    Comprobante = new ComprobanteModel
                    {
                        Numero_Comprobante = 1,
                        ID_Comprobantes = 1
                    },
                    Tipo_Pago = 2
                },
                AssertRetencion = "assert"
            };

            return new[] {
                new TestDataSource_UserStory_One[] { testRetencionesParams },
                new TestDataSource_UserStory_One[] { testRetencionesParams2 },
                new TestDataSource_UserStory_One[] { testRetencionesParams3 }
            };
            //yield return new TestRetenciones[] { testRetencionesParams };
            //yield return new TestRetenciones[] { testRetencionesParams2 };
        }
        public static IEnumerable<TestDataSource_UserStory_One[]> RetencionIvaCaso2()
        {
            TestDataSource_UserStory_One testRetencionesParams = new TestDataSource_UserStory_One()
            {
                OrdenPago = new ComprobanteOPModel()
                {
                    Comprobante = new ComprobanteModel
                    {
                        Numero_Comprobante = 1,
                        ID_Comprobantes = 1
                    },
                    Tipo_Pago = 2
                },
                AssertRetencion = "assert"
            };
           
            return new[] {
                new TestDataSource_UserStory_One[] { testRetencionesParams }
              };
            //yield return new TestRetenciones[] { testRetencionesParams };
            //yield return new TestRetenciones[] { testRetencionesParams2 };
        }
    }
}
