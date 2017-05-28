using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class AudiA3 : ICar
    {
        private string description;
        private double price;

        public AudiA3()
        {
            description = "Audi A3";
            price = 40000.00;
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
