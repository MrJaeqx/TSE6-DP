using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W1_Strategy
{
    // SCAN Disk Scheduling

    class SCANScheduling : IDiskScheduling
    {
        public void ReadDisk(List<int> requests)
        {
            try
            {
                /*if (requests.Count > 0)
                {
                    requests.Remove(0);
                }
                int startNumber = 50;

                // find closest to number
                int closest = list.OrderBy(item => Math.Abs(startNumber - item)).First();*/
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: SCAN read disk.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(-1);
            }
        }
    }
}
