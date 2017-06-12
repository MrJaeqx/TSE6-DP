using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StockMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            StockSubject stockSubject = new StockSubject();
            
            stockSubject.Attach(new PhoneObserver(stockSubject));
            stockSubject.Attach(new MatrixBoardObserver(stockSubject));
            stockSubject.Attach(new NewspaperObserver(stockSubject));

            Console.WriteLine("Press ESC to exit, 1 to add a random observer, 2 to remove an observer");

            int i = 0;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Escape)
                        return;
                    else if (key == ConsoleKey.D1)
                        addObserver(stockSubject);
                    else if (key == ConsoleKey.D2)
                        deleteObserver(stockSubject);
                }

                stockSubject.SetState("Tick: " + i);
                stockSubject.Notify();
                Thread.Sleep(500);
                i++;
            }
        }

        // Adds random observer
        private static void addObserver(StockSubject s)
        {
            Random rand = new Random();
            int choice = rand.Next(1, 4);

            IObserver randObserver;
            switch (choice)
            {
                case 1:
                    randObserver = new PhoneObserver(s);
                    break;
                case 2:
                    randObserver = new MatrixBoardObserver(s);
                    break;
                case 3:
                    randObserver = new NewspaperObserver(s);
                    break;
                default:
                    randObserver = new NewspaperObserver(s);
                    break;
            }
            s.Attach(randObserver);

        }

        // Removes random observer
        static void deleteObserver(Subject s)
        {
            int count = s.GetObservers().Count;
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nothing to delete!");
                return;
            }
            Random rand = new Random();
            int choice = rand.Next(0, count-1);
            s.Detach(s.GetObservers()[choice]);
        }
    }
}
