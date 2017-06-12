using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    class NewspaperObserver : IObserver
    {
        private StockSubject subject;

        public NewspaperObserver(StockSubject s)
        {
            subject = s;
        }

        public void Update()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("News says:   " + subject.GetState());
        }

    }
}
