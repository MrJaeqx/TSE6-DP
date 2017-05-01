using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W1_Strategy
{
    // First-Come First-Serve Disk Scheduling

    class FCFSScheduling : IDiskScheduling
    {
        public void ReadDisk(List<int> requests)
        {
            try
            {
                if (requests.Count > 0)
                {
                    requests.Remove(0);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: FCFS read disk.");
                Console.WriteLine("Press any key to exit...");
                getChar();
                Environment.Exit(-1);
            }
            
        }
    }
}
