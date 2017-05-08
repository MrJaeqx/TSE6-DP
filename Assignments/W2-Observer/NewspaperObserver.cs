using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    class NewspaperObserver : IObserver
    {
        private ISubject subject;

        public NewspaperObserver(ISubject s)
        {
            subject = s;
        }

        public void Update()
        {
            StockState state = subject.GetState();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Krant zegt:    " + state.GetStringThing());
        }

        public void UpdatePush(StockState s)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Krant zegt:    " + s.GetStringThing());
        }

    }
}
