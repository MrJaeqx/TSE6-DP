using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Builder
{
    class PCShop
    {
        public PCShop()
        {
            
        }

        public void BuildPC(PCBuilder builder)
        {
            builder.BuildCPU();
            builder.BuildRAM();
            builder.BuildGPU();
            builder.BuildHDD();
        }
    }
}
