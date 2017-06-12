using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Builder
{
    class DesktopBuilder : PCBuilder
    {
        public DesktopBuilder()
        {
            pc = new PC("Desktop");
        }

        public override void BuildCPU()
        {
            pc["cpu"] = "AMD R9 ThreadRipper";
        }

        public override void BuildRAM()
        {
            pc["ram"] = "8x16GB DDR4";
        }

        public override void BuildGPU()
        {
            pc["gpu"] = "2x NVIDIA GeForce 1080Ti";
        }

        public override void BuildHDD()
        {
            pc["hdd"] = "2x 1TB NVMe SSD @ RAID0";
        }
    }
}
