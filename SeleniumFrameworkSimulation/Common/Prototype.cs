using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFrameworkSimulation.Common
{
    public abstract class Prototype
    {
        public abstract Prototype DeepCopy();

        public abstract Prototype ShallowCopy();
    }
}
