using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace W1_Strategy
{
    class DiskConsole
    {
        private static List<int> requests = new List<int>(new int[] { 19, 4, 21, 3, 97, 40, 50, 62, 10, 86, 2 });

        static void Main(string[] args)
        {
            Console.WriteLine("1: First-Come First-Serve");
            Console.WriteLine("2: Shortest Seek Time First");
            Console.WriteLine("3: SCAN");
            string result = "";
            bool validChoice = false;
            int choice;
            Console.WriteLine("Choose scheduling strategy: ");
            result = Console.ReadLine();
            Int32.TryParse(result, out choice);

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

            Console.WriteLine("Using: ");
            foreach (int request in requests)
            {
                Console.Write(request + " ");
            }
            Console.WriteLine();

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += delegate
            {
                ScheduleRead(strategy, timer);
            };

            timer.Start();
            
            //Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void ScheduleRead(IDiskScheduling strategy, Timer timer)
        {
            strategy.ReadDisk(requests);
            foreach (int request in requests)
            {
                Console.Write(request + " ");
            }
            Console.WriteLine();
            if (requests.Count == 0)
            {
                Console.WriteLine("Reading done");
                timer.Stop();
            }
        }
    }
}
