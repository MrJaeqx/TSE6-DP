using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    abstract class Subject
    {
        List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach(var observer in observers)
            {
                observer.Update();
            }
        }

        public List<IObserver> GetObservers()
        {
            return observers;
        }
    }
}
