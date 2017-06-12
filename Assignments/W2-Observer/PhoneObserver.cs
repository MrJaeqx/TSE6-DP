using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    class PhoneObserver : IObserver
    {
        private StockSubject subject;

        public PhoneObserver(StockSubject s)
        {
            subject = s;
        }

        public  void Update()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Phone says:   " + subject.GetState());
        }
    }
}
