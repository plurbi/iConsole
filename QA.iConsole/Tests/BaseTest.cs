using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
namespace QA.iConsole.Tests
{
    [TestClass]
    public class BaseTest
    {

    }
}
