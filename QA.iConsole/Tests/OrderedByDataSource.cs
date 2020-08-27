using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.iConsole.DataLoaders;
using QA.iConsole.Exceptions;
using QA.iConsole.Models.TestObjects;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QA.iConsole.Tests
{
    [TestClass]
    public class OrderedByDataSource
    {
        // declaro datos comportidos entre tests
        string datoCompartido = "Todavia no lo inicialice";
        public OrderedByDataSource()
        {
            //Inicializo datos compartidos entre tests
        }
      
        /// <summary>
        /// Este test obtiene una list de string la ordena alfabeticamente
        /// y los ejecuta de manera sincrona si falla uno se corta el test
        /// solo se debe usar estos metods para casos de prueba generales
        /// </summary>
        /// <param name="data"></param>
        [TestMethod]
        [DynamicData(nameof(OrderListDataLoader.OrderListDataSource), typeof(OrderListDataLoader), DynamicDataSourceType.Method)]
        public void OrderedTests(TestDataSource_UserStory_Two data)
        {
            try
            {
                foreach (string methodName in data.OrderList.OrderBy(name => name))
                {
                    // NO usar Polly aca, porque solo lleguan TargetInvocationException
                    System.Reflection.MethodInfo method = GetType().GetMethod(methodName);
                    method.Invoke(this, new object[] { "PrimerParametro", true });
                }
            }           
            catch(TargetInvocationException tiEx)
            {
                if (tiEx is TargetInvocationException)
                {
                    if (tiEx?.InnerException is AssertFailedException)
                    {
                        Debug.WriteLine(tiEx.InnerException.Message);
                        throw tiEx.InnerException;
                    }
                }                
                // Si falla el metodo se corta, se arroja la inner Exception
                // Se usa el metodo ManageException
                throw;
            }
            catch (Exception ex)
            {
                //  se arroja una excepcion personalizada
                // Se usa el metodo ManageException
                throw new OrderListExecutionException(ex.Message);
            }
        }

        public void Method_01(string primerParametro, bool a)
        {
            Debug.WriteLine(datoCompartido);
            datoCompartido = "Method_01";
            Assert.IsTrue(a);
        }

        public void Method_02(string primerParametro, bool a)
        {
            Debug.WriteLine(datoCompartido);
            datoCompartido = "Method_02";
            Assert.IsTrue(!a);
        }

        public void Method_03(string primerParametro, bool a)
        {
            Assert.IsTrue(a);
        }
    }
}
