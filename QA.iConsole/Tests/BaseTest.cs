using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFrameworkSimulation.Common.Prototype;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
namespace QA.iConsole.Tests
{
    [TestClass]
    public class BaseTest
    {
        protected PrototypeManager _prototypeManager;
        public BaseTest()
        {
            _prototypeManager = new PrototypeManager();
        }

    }
}
