using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Builder
{
    class LaptopBuilder : PCBuilder
    {
        public LaptopBuilder()
        {
            pc = new PC("Laptop");
        }

        public override void BuildCPU()
        {
            pc["cpu"] = "Intel Core m3";
        }

        public override void BuildRAM()
        {
            pc["ram"] = "2x8GB DDR4";
        }

        public override void BuildGPU()
        {
            pc["gpu"] = "1x NVIDIA GeForce 1060M";
        }

        public override void BuildHDD()
        {
            pc["hdd"] = "1x 512GB mSATA SSD";
        }
    }
}
