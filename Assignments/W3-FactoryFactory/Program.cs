using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3_FactoryFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 or 2 to choose a type or Q to quit");
            Console.WriteLine("1: Smurf");
            Console.WriteLine("2: Minion");

            IFactory thingFactory = null;

            bool validChoice = false;
            while (!validChoice)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        thingFactory = new SmurfFactory();
                        validChoice = true;
                        break;
                    case ConsoleKey.D2:
                        thingFactory = new MinionFactory();
                        validChoice = true;
                        break;
                    case ConsoleKey.Q:
                        return;
                    default:
                        Console.WriteLine("Try again. It's not hard. 1 or 2.");
                        break;
                }
            }
            
            Console.WriteLine("Running the " + thingFactory.GetType().Name + " variant.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            GenericGame spiel = new GenericGame();
            spiel.Run(thingFactory);

        }
    }
}
