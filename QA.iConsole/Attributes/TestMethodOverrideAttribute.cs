using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.iConsole.Attributes
{
    class TestMethodOverrideAttribute : TestMethodAttribute
    {
        
            public override TestResult[] Execute(ITestMethod testMethod)
            {
                TestResult[] result = null;
            System.Diagnostics.Debug.WriteLine("Test Method Override");
                return result;
            }

            private TestResult[] Invoke(ITestMethod testMethod)
            {
                return new[] { testMethod.Invoke(null) };
            }
        }
    }

