using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class Airco : CarDecorator
    {
        private double price = 2000.00;
        public Airco(Car car) : base(car)
        {

        }

        public new double GetPrice()
        {
            return base.GetPrice() + price;
        }

        public new string GetDescription()
        {
            return base.GetDescription() + " with Airco";
        }

        public string Chill()
        {
            return "Fwoooooooooooooooo";
        }
    }
}
