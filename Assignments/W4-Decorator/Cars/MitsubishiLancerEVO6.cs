using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class MitsubishiLancerEVO6 : ICar
    {
        private string description;
        private double price;

        public MitsubishiLancerEVO6()
        {
            description = "Mitsubishi Lancer EVO 6";
            price = 20000.00;
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
