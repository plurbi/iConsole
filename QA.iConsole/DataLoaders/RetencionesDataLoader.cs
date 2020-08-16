﻿using QA.iConsole.Models.TestObjects;
using System.Collections.Generic;

namespace QA.iConsole.DataLoaders
{
    public static class RetencionesDataLoader
    {
        public static IEnumerable<TestRetenciones[]> RetencionIvaCaso1()
        {
            TestRetenciones testRetencionesParams = new TestRetenciones()
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
            TestRetenciones testRetencionesParams2 = new TestRetenciones()
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
                new TestRetenciones[] { testRetencionesParams },
                new TestRetenciones[] { testRetencionesParams2 }
            };
            //yield return new TestRetenciones[] { testRetencionesParams };
            //yield return new TestRetenciones[] { testRetencionesParams2 };
        }
    }
}
