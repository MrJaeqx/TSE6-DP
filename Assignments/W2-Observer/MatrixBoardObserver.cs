using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    class MatrixBoardObserver : IObserver
    {
        private StockSubject subject;

        public MatrixBoardObserver(StockSubject s)
        {
            subject = s;
        }

        public void Update()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Matrix says:   " + subject.GetState());
        }
    }
}
