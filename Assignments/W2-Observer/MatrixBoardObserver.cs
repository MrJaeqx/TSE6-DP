using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    class MatrixBoardObserver : IObserver
    {
        private ISubject subject;

        public MatrixBoardObserver(ISubject s)
        {
            subject = s;
        }

        public void Update()
        {

            StockState state = subject.GetState();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Matrix zegt:   " + state.GetStringThing());
        }

        public void UpdatePush(StockState s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Matrix zegt:   " + s.GetStringThing());
        }
    }
}
