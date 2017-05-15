using System;

namespace W3_FactoryFactory
{
    internal class BananaPhone : IPhone
    {
        public void explode()
        {
            Console.WriteLine("I'm not a Samsung tho");
        }

        public void call()
        {
            Console.WriteLine("Ring ring ring ring ring ring ring banana phone \n Boop - boo - ba - doo - ba - doop");
        }

        public void bootloop()
        {
            Console.WriteLine("I'm not an LG tho");
        }
    }
}
