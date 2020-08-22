using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.iConsole.Models.TestObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QA.iConsole.Attributes
{
    public class RetencionesDataSourceAttribute : Attribute, ITestDataSource
    {
        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
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

                    Tipo_Pago = 1
                },
                AssertRetencion = "assert"
            };
            TestRetenciones testRetencionesParams2 = new TestRetenciones()
            {
                OrdenPago = new ComprobanteOPModel()
                {
                    Comprobante = new ComprobanteModel
                    {
                        Numero_Comprobante = 2,
                        ID_Comprobantes = 2
                    },
                    Tipo_Pago = 2
                },
                AssertRetencion = "assert"
            };
            TestRetenciones testRetencionesParams3 = new TestRetenciones()
            {
                OrdenPago = new ComprobanteOPModel()
                {
                    Comprobante = new ComprobanteModel
                    {
                        Numero_Comprobante = 3,
                        ID_Comprobantes = 3
                    },
                    Tipo_Pago = 3
                },
                AssertRetencion = "assert-fail"
            };
            return new[] {
                new TestRetenciones[] { testRetencionesParams },
                new TestRetenciones[] { testRetencionesParams2 },
                new TestRetenciones[] { testRetencionesParams3 }
            };
        }

        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data != null)
                return string.Format(CultureInfo.CurrentCulture, "Custom - {0} ({1})", methodInfo.Name, string.Join(",", data));

            return null;
        }
    }
}
