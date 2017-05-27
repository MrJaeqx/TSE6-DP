using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class Car : ICar
    {
        public Car()
        {
            
        }
        public double GetPrice()
        {
            return 5000.0;
        }

        public string GetDescription()
        {
            return "I'm just a regular no-brand car!";
        }
    }
}
