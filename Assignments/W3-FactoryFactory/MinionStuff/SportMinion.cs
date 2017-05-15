using System;

namespace W3_FactoryFactory
{
    internal class SportMinion : IFigure
    {
        public void walk()
        {
            Console.WriteLine("steps");
        }

        public void jump()
        {
            Console.WriteLine("hop");
        }

        public void run()
        {
            Console.WriteLine("woosh");
        }

        public void sing()
        {
            Console.WriteLine("I can't sing!");
        }
    }
}