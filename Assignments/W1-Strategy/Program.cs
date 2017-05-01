using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace W1_Strategy
{
    class DiskConsole
    {
        private List<int> requests = new List<int>(new int[] { 19, 4, 21, 3, 97, 40, 50, 62, 10, 86, 2 });

        static void Main(string[] args)
        {
            int choice = 0;// iets met console input
            IDiskScheduling strategy;
            switch (choice)
            {
                case 1:
                    strategy = new FCFSScheduling();
                    break;
                case 2:
                    strategy = new SSTFScheduling();
                    break;
                case 3:
                    strategy = new SCANScheduling();
                    break;
                default:
                    strategy = new FCFSScheduling();
                    break;
            }

            //Thread thread = new Thread(new ThreadStart(strategy.ReadDisk(requests)));

            while (true)
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
