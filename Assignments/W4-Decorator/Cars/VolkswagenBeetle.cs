using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class VolkswagenBeetle : ICar
    {
        private string description;
        private double price;

        public VolkswagenBeetle()
        {
            description = "Volkswagen Beetle";
            price = 3500.00;
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
