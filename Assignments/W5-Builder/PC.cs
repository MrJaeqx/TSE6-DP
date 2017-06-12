using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace W5_Builder
{
    class PC
    {
        private string pcType;
        private Dictionary<string, string> parts = new Dictionary<string, string>();

        public PC(string pcType)
        {
            this.pcType = pcType;
        }

        public string this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("PC Type: {0}", pcType);
            Console.WriteLine(" CPU : {0}", parts["cpu"]);
            Console.WriteLine(" RAM : {0}", parts["ram"]);
            Console.WriteLine(" GPU : {0}", parts["gpu"]);
            Console.WriteLine(" HDD : {0}", parts["hdd"]);
        }

    }
}
