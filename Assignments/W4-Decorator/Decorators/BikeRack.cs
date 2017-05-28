using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator.Decorators
{
    class BikeRack : CarDecorator
    {
        private ICar car;

        public BikeRack(ICar car) : base(car)
        {
            this.car = car;
        }

        public override double GetPrice()
        {
            return car.GetPrice() + 2500.00;
        }

        public override string GetDescription()
        {
            return car.GetDescription() + " + bike rack";
        }
    }
}
