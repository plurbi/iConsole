using QA.iConsole.Models.TestObjects;
using SeleniumFrameworkSimulation.Models;
using System.Collections.Generic;

namespace QA.iConsole.DataLoaders
{
    public static class UserStorysDataLoader
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

        public static IEnumerable<TestDataSource_UserStory_One[]> DataLoadersWithPrototype()
        {
            TestDataSource_UserStory_One testOriginal = new TestDataSource_UserStory_One()
            {
                OrdenPago = new ComprobanteOPModel()
                {
                    Comprobante = new ComprobanteModel
                    {
                        Numero_Comprobante = 1,
                        ID_Comprobantes = 1
                    },
                    Tipo_Pago = 1,
                    Observaciones = "obs original"
                },
                AssertRetencion = "assert"
            };
            TestDataSource_UserStory_One testConClonacion = new TestDataSource_UserStory_One()
            {
                AssertRetencion = "assert"
            };

            ComprobanteOPModel ordenPagoClon = (ComprobanteOPModel)testOriginal.OrdenPago.DeepCopy();
            testConClonacion.OrdenPago = ordenPagoClon;

            testOriginal.OrdenPago.Comprobante.ID_Comprobantes = 2;
            testOriginal.OrdenPago.Comprobante.Numero_Comprobante = 2;
            testOriginal.OrdenPago.Tipo_Pago = 2;
            testOriginal.OrdenPago.Observaciones = "original modificado";

            return new[] {
                new TestDataSource_UserStory_One[] {  testOriginal },
                new TestDataSource_UserStory_One[] {  testConClonacion }
              };
            //yield return new TestRetenciones[] { testRetencionesParams };
            //yield return new TestRetenciones[] { testRetencionesParams2 };
        }
    }
}
