using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator.Decorators
{
    class Towhook : CarDecorator
    {
        private ICar car;

        public Towhook(ICar car) : base(car)
        {
            this.car = car;
        }

        public override double GetPrice()
        {
            return car.GetPrice() + 559.95;
        }

        public override string GetDescription()
        {
            return car.GetDescription() + " + tow hook";
        }

    }
}
