using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W1_Strategy
{
    // SCAN Disk Scheduling

    class SCANScheduling : IDiskScheduling
    {
        private int startPos = 50;


        public void ReadDisk(List<int> requests)
        {
            try
            {
                if (requests.Count > 0)
                {
                    // find closest to startPos
                    int closest = requests.OrderBy(item => (startPos - item) < 0 ? startPos + item : startPos - item).First();
                    requests.Remove(closest);
                }
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
