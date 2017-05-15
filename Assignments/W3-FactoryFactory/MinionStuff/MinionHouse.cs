using System;

namespace W3_FactoryFactory
{
    internal class MinionHouse : IHouse
    {
        public void burnDown()
        {
            Console.WriteLine("I'm burning pls help");
        }

        public void openDoor()
        {
            Console.WriteLine("My door's opening!");
        }
    }
}