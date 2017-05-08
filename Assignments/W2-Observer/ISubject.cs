using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    interface ISubject
    {
        List<IObserver> GetObservers();

        void Attach(IObserver o);
        void Detach(IObserver o);

        void Notify();
        StockState GetState();
    }
}
