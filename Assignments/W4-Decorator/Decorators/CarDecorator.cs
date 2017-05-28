using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    abstract class CarDecorator : ICar
    {
        private ICar car;

        protected CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual double GetPrice()
        {
            return car.GetPrice();
        }

        public virtual string GetDescription()
        {
            return car.GetDescription();
        }
    }
}
