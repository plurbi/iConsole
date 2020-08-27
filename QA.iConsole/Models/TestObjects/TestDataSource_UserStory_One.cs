using QA.iConsole.Tests;
using System.Collections.Generic;

namespace QA.iConsole.Models.TestObjects
{
    //Esto se nomencla TestDataSource_RetencionesParaguay
    public class TestDataSource_UserStory_One
    {
        public ComprobanteOPModel OrdenPago { get; set; }
        public string AssertRetencion { get; set; }
    }
    public class TestDataSource_UserStory_Two
    {
        public List<string> OrderList { get; set; } = new List<string>();        
    }
}
