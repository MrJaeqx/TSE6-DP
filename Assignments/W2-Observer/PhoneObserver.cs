using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    class PhoneObserver : IObserver
    {
        private ISubject subject;

        public PhoneObserver(ISubject s)
        {
            this.subject = s;
        }

        public void Update()
        {
            StockState state = subject.GetState();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Telefoon zegt: " + state.GetStringThing());
        }

        public void UpdatePush(StockState s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Telefoon zegt: " + s.GetStringThing());
        }
    }
}
