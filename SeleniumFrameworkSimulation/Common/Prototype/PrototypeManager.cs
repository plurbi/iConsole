using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFrameworkSimulation.Common.Prototype
{
    public class PrototypeManager
    {
        private Dictionary<string, AlborQaPrototype> _dict = new Dictionary<string, AlborQaPrototype>();

        public AlborQaPrototype this[string key]
        {
            get { return _dict[key]; }
            set { _dict.Add(key, value); }
        }
    }
}
