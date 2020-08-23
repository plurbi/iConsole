using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using QA.iConsole.Extensions;
using System;
using System.Threading;

namespace QA.iConsole.Tests
{
    [TestClass]
    public class LifeCycleTests
    {
        string stringSharedTest = null;
        public LifeCycleTests()
        {
            stringSharedTest = "Constructor";
            Debug.WriteLine($"Constructor -> {stringSharedTest}");
        }

        #region Metodos 
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Debug.WriteLine(DateTime.Now.ToString());
            Debug.WriteLine("LifeCycle - AssemblyInitialize");
        }

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            Debug.WriteLine("ClassInitialize");
            // Executes once for the test class. (Optional)
        }

        [TestInitialize]
        public void Setup()
        {
            stringSharedTest = "TestInitialize";
            Debug.WriteLine(stringSharedTest);
            // Runs before each test. (Optional)
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine(DateTime.Now.ToString());
            Debug.WriteLine("LifeCycle - AssemblyCleanup");
            // Executes once after the test run. (Optional)
        }

        [ClassCleanup]
        public static void TestFixtureTearDown()
        {
            Debug.WriteLine("ClassCleanup");
            // Runs once after all tests in this class are executed. (Optional)
            // Not guaranteed that it executes instantly after all tests from the class.
        }

        [TestCleanup]
        public void TearDown()
        {
            stringSharedTest = "TestCleanup";
            Debug.WriteLine(stringSharedTest);
            // Runs after each test. (Optional)
        }

        #endregion

        [TestMethod]
        public void LifeCycle()
        {
            stringSharedTest = "TEST 1!!!";
            Debug.WriteLine(stringSharedTest);
        }
        [TestMethod]
        public void LifeCycle2()
        {
            stringSharedTest = "TEST 2!!!";

            Debug.WriteLine(stringSharedTest);
        }
        [TestMethod]
        public void Parallel_wait_5_secs()
        {
            Thread.Sleep(5000);
        }
        [TestMethod]
        public void Parallel_wait_10_secs()
        {
            Thread.Sleep(10000);
        }
    }
}