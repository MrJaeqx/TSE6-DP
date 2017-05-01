using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W1_Strategy
{
    // Shortest Seek Time First Disk Scheduling
    class SSTFScheduling : IDiskScheduling
    {
        public void ReadDisk(List<int> requests)
        {
            try
            {
                if (requests.Count > 0)
                {
                    // find closest to number
                    int closest = requests.OrderBy(item => Math.Abs(startNumber - item)).First();
                    requests.Remove(closest);
                }             
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: SCAN read disk.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(-1);
            }
        }
    }
}
