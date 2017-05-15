using System;

namespace W3_FactoryFactory
{
    internal class SmurfBerry : IPhone
    {
        public void explode()
        {
            Console.WriteLine("I'm not a Samsung tho");
        }

        public void call()
        {
            Console.WriteLine("Ring!");
        }

        public void bootloop()
        {
            Console.WriteLine("I'm not an LG tho");
        }
    }
}