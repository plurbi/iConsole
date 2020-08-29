using SeleniumFrameworkSimulation.Common.Prototype;
using SeleniumFrameworkSimulation.Models;
using System.Collections.Generic;

namespace QA.iConsole.Models.TestObjects
{
    //Esto se nomencla TestDataSource_RetencionesParaguay
    public class TestDataSource_UserStory_One : Prototype
    {
        public ComprobanteOPModel OrdenPago { get; set; }
        public string AssertRetencion { get; set; }

        public override Prototype GetClon()
        {
            TestDataSource_UserStory_One test = (TestDataSource_UserStory_One)this.MemberwiseClone();
            test.OrdenPago = (ComprobanteOPModel)this.OrdenPago.GetClon();
            return test;
        }
    }
    public class TestDataSource_UserStory_Two
    {
        public List<string> OrderList { get; set; } = new List<string>();        
    }
}
