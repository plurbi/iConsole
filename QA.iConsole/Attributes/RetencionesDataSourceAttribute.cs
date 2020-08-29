using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.iConsole.Models.TestObjects;
using SeleniumFrameworkSimulation.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace QA.iConsole.Attributes
{
    public class RetencionesDataSourceAttribute : Attribute, ITestDataSource
    {
        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
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

                    Tipo_Pago = 1
                },
                AssertRetencion = "assert"
            };
            TestDataSource_UserStory_One testRetencionesParams2 = new TestDataSource_UserStory_One()
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
            TestDataSource_UserStory_One testRetencionesParams3 = new TestDataSource_UserStory_One()
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
                AssertRetencion = "assert"
            };
            return new[] {
                new TestDataSource_UserStory_One[] { testRetencionesParams },
                new TestDataSource_UserStory_One[] { testRetencionesParams2 },
                new TestDataSource_UserStory_One[] { testRetencionesParams3 }
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
