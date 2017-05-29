using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Command
{
    class Add : ICallback
    {
        private Receiver _receiver;
        private int _a;
        private int _b;

        public Add(Receiver receiver, int a, int b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }
        public void execute()
        {
            _receiver.Add(_a, _b);
        }
    }
}
