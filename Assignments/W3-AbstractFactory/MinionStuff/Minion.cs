using System;

namespace W3_FactoryFactory
{
    internal class Minion : IFigure
    {
        public void walk()
        {
            Console.WriteLine("steps");
        }

        public void jump()
        {
            Console.WriteLine("falls");
        }

        public void run()
        {
            Console.WriteLine("stumbles");
        }

        public void sing()
        {
            Console.WriteLine("herrie");
        }
    }
}