using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W1_Strategy
{
    // Shortest Seek Time First Disk Scheduling
    class SSTFScheduling : IDiskScheduling
    {
        private int startItem = -1;

        public void ReadDisk(List<int> requests)
        {
            try
            {
                if (startItem == -1)
                {
                    startItem = requests[0];
                }
                if (requests.Count > 0)
                {
                    // find closest to number
                    int closest = requests.Aggregate((x, y) => Math.Abs(x - startItem) < Math.Abs(y - startItem) ? x : y);
                    requests.Remove(closest);
                }             
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: SSTF read disk.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(-1);
            }
        }
    }
}
