using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class Navigation : CarDecorator
    {
        private ICar car;

        public Navigation(ICar car) : base(car)
        {
            this.car = car;
        }

        public override double GetPrice()
        {
            return car.GetPrice() + 200.00;
        }

        public override string GetDescription()
        {
            return car.GetDescription() + " + navigation";
        }

        public string Navigate()
        {
            return "Navigating...";
        }
    }
}
