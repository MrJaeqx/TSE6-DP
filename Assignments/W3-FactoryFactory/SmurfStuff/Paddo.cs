using System;

namespace W3_FactoryFactory
{
    internal class Paddo : IHouse
    {
        public void burnDown()
        {
            Console.WriteLine("How did a mushroom even self-ignite?!");
        }

        public void openDoor()
        {
            Console.WriteLine("My door's opening!");
        }
    }
}
