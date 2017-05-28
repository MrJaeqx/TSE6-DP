using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class RegularCar : ICar
    {
        private string description;
        private double price;

        public RegularCar()
        {
            description = "Regular car";
            price = 20000.00;
        }

        public double GetPrice()
        {
            return price;
        }

        public string GetDescription()
        {
            return description;
        }
    }
}
