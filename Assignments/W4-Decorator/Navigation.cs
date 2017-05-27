using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class Navigation : CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            
        }

        public new double GetPrice()
        {
            return base.GetPrice() + 200.00;
        }

        public new string GetDescription()
        {
            return "With navigation";
        }
    }
}
