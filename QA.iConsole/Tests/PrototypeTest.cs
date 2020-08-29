using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFrameworkSimulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.iConsole.Tests
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void TestDeepClonPrototype()
        {
            ComprobanteOPModel original = new ComprobanteOPModel();
            original.Comprobante.ID_Comprobantes = 1;
            original.Comprobante.Numero_Comprobante = 1;
            original.Observaciones = "Observacion original";
            original.Tipo_Pago = 1;

            ComprobanteOPModel duplicado = (ComprobanteOPModel)original.GetClon();

            Console.WriteLine($"Original {original.Comprobante.Numero_Comprobante}, {original.Tipo_Pago}, {original.Observaciones}");

            Console.WriteLine($"Duplicado {duplicado.Comprobante.Numero_Comprobante}, {duplicado.Tipo_Pago}, {original.Observaciones}");

            original.Comprobante.ID_Comprobantes = 3;
            original.Comprobante.Numero_Comprobante = 3;
            original.Tipo_Pago = 3;
            original.Observaciones = "Observacion modificada";

            Console.WriteLine($"Original {original.Comprobante.Numero_Comprobante}, {original.Tipo_Pago}, {original.Observaciones}");

            Console.WriteLine($"Duplicado {duplicado.Comprobante.Numero_Comprobante}, {duplicado.Tipo_Pago}, {original.Observaciones}");
        }

        [TestMethod]
        public void TestDeepCopyPrototype()
        {
            ComprobanteOPModel original = new ComprobanteOPModel();
            original.Comprobante.ID_Comprobantes = 1;
            original.Comprobante.Numero_Comprobante = 1;
            original.Observaciones = "Observacion original";
            original.Tipo_Pago = 1;

            ComprobanteOPModel duplicado = (ComprobanteOPModel)original.GetClon();

            Console.WriteLine($"Original {original.Comprobante.Numero_Comprobante}, {original.Tipo_Pago}");

            Console.WriteLine($"Duplicado {duplicado.Comprobante.Numero_Comprobante}, {duplicado.Tipo_Pago}");

            original.Comprobante.ID_Comprobantes = 3;
            original.Comprobante.Numero_Comprobante = 3;
            original.Tipo_Pago = 3;
            original.Observaciones = "Observacion modificada";

            Console.WriteLine($"Original {original.Comprobante.Numero_Comprobante}, {original.Tipo_Pago}");

            Console.WriteLine($"Duplicado {duplicado.Comprobante.Numero_Comprobante}, {duplicado.Tipo_Pago}");


        }
    }
}
