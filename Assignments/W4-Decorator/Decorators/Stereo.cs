using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class Stereo : CarDecorator
    {
        private ICar car;

        public Stereo(ICar car) : base(car)
        {
            this.car = car;
        }

        public override double GetPrice()
        {
            return car.GetPrice() + 1500.00;
        }

        public override string GetDescription()
        {
            return car.GetDescription() + " + stereo";
        }
    }
}
