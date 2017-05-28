using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class FordTaunus : ICar
    {
        private string description;
        private double price;

        public FordTaunus()
        {
            description = "Ford Taunus";
            price = 5000.00;
        }

        public string GetDescription()
        {
            return description;
        }

        public double GetPrice()
        {
            return price;
        }
    }
}
