using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W4_Decorator
{
    class Stereo : CarDecorator
    {
        public Stereo(ICar car) : base(car)
        {

        }

        public new double GetPrice()
        {
            return base.GetPrice() + 1500.00;
        }

        public new string GetDescription()
        {
            return base.GetDescription() + " /w Stereo";
        }

        public string PlayMusic()
        {
            return "Playing music";
        }
    }
}
