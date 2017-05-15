using System;

namespace W3_FactoryFactory
{
    internal class Miniette : IFigure
    {
        public void walk()
        {
            Console.WriteLine("steps");
        }

        public void jump()
        {
            Console.WriteLine("fall");
        }

        public void run()
        {
            Console.WriteLine("stumble");
        }

        public void sing()
        {
            Console.WriteLine("ladidaa");
        }
    }
}