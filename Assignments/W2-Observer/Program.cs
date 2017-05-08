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
            StockState state = new StockState();
            ISubject stockSubject = new StockSubject(state);

            IObserver phoneObserver = new PhoneObserver(stockSubject);
            IObserver matrixObserver = new MatrixBoardObserver(stockSubject);
            IObserver newspaperObserver = new NewspaperObserver(stockSubject);

            stockSubject.Attach(phoneObserver);
            stockSubject.Attach(matrixObserver);
            stockSubject.Attach(newspaperObserver);


            int i = 0;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Escape)
                        return;
                    else if (key == ConsoleKey.D1)
                        addObserver(ref stockSubject);
                    else if (key == ConsoleKey.D2)
                        deleteObserver(ref stockSubject);
                }

                state.SetStringThing("Tick: " + i);
                stockSubject.Notify();
                Thread.Sleep(1);
                i++;
            }
        }

        // Adds random observer
        static private void addObserver(ref ISubject s)
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
        static private void deleteObserver(ref ISubject s)
        {
            int count = s.GetObservers().Count;
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("doe ff nie niks verwijderen");
                return;
            }
            Random rand = new Random();
            int choice = rand.Next(0, count-1);
            s.Detach(s.GetObservers()[choice]);
        }
    }
}
