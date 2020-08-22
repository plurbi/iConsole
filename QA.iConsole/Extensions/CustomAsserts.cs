using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.iConsole.Extensions
{
    public static class CustomAsserts
    {
        public static void ExampleExtensionAssert(this Assert assert, string expected, string actual)
        {
            if (expected == actual)
                return;

            throw new AssertFailedException("Cutom extension failure message example");
        }
    }
}
