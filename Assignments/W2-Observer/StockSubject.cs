using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    class StockSubject : ISubject
    {
        public List<IObserver> observers = new List<IObserver>();
        private StockState stockState;

        public StockSubject(StockState s)
        {
            stockState = s;
        }

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
            foreach(IObserver o in observers)
            {
                o.Update();
            }
        }

        public StockState GetState()
        {
            return stockState;
        }

        public List<IObserver> GetObservers()
        {
            return observers;
        }
    }
}
