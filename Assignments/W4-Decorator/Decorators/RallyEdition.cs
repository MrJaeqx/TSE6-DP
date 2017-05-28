using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class RallyEdition : CarDecorator
    {
        private ICar car;

        public RallyEdition(ICar car) : base(car)
        {
            this.car = car;
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 500000.00;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + Rally Edition";
        }

    }
}
