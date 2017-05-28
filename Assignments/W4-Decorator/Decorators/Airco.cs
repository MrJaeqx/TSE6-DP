using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class Airco : CarDecorator
    {
        private ICar car;

        public Airco(ICar car) : base(car)
        {
            this.car = car;
        }

        public override double GetPrice()
        {
            return car.GetPrice() + 2000.00;
        }

        public override string GetDescription()
        {
            return car.GetDescription() + " + airco";
        }

        public string Chill()
        {
            return "Setting to 16c";
        }
    }
}
