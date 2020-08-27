using QA.iConsole.Models.TestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.iConsole.DataLoaders
{

    public static class OrderListDataLoader
    {

        public static IEnumerable<TestDataSource_UserStory_Two[]> OrderListDataSource()
        {
            TestDataSource_UserStory_Two testListDataSource = new TestDataSource_UserStory_Two()
            {
                OrderList = new List<string>()
               {
                   "Method_01",
                   "Method_02",
                   "Method_03"
               }
            };

            return new[] {
                new TestDataSource_UserStory_Two[] { testListDataSource }
              };
            //yield return new TestRetenciones[] { testRetencionesParams };
            //yield return new TestRetenciones[] { testRetencionesParams2 };
        }
    }
}
