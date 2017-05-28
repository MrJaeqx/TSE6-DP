using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class BMWX3 : ICar
    {

        private string description;
        private double price;

        public BMWX3()
        {
            description = "BMW X3";
            price = 150000.00;
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
