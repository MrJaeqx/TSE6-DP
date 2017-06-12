using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Builder
{
    abstract class PCBuilder
    {
        protected PC pc;

        public PC PC
        {
            get { return pc; }
        }

        public abstract void BuildCPU();
        public abstract void BuildRAM();
        public abstract void BuildGPU();
        public abstract void BuildHDD();
    }
}
