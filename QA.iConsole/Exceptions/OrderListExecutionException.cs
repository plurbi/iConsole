using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.iConsole.Exceptions
{
    public class OrderListExecutionException : Exception
    {
        public OrderListExecutionException(string message) : base(message)
        {

        }
    }
}
