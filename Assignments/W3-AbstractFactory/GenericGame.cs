using System;
using System.Threading;

namespace W3_FactoryFactory
{
    public class GenericGame
    {
        private IFactory factory = null;
        private IFigure myFigure = null;
        private IGadget prize = null;
        private int totalSteps = 0;
        private int totalPoints = 0;
        private int maxSteps = 1000;
        private int pointThreshold = 250;
        

        public void Run(IFactory stuffFactory)
        {
            factory = stuffFactory;
            bool validChoice = false;
            while (!validChoice)
            {
                string type = (factory.GetType().Name).Replace("Factory", "");
                Console.WriteLine("Press 1 for male " + type);
                Console.WriteLine("Press 2 for female " + type);
                Console.WriteLine("Press 3 for sport " + type);

                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        myFigure = stuffFactory.createMaleFigure();
                        validChoice = true;
                        break;
                    case ConsoleKey.D2:
                        myFigure = stuffFactory.createFemaleFigure();
                        validChoice = true;
                        break;
                    case ConsoleKey.D3:
                        myFigure = stuffFactory.createSportFigure();
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        break;
                }
            }

            Random random = new Random();
            
            Console.WriteLine("Press Escape stop game");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }

                if (totalSteps >= maxSteps)
                {
                    break;
                }

                myFigure.jump();
                myFigure.sing();

                totalSteps += random.Next(0, 150);
                totalPoints += random.Next(1, 35);
                
                if (myFigure.GetType().Name.Contains("Sport"))
                {
                    totalSteps += random.Next(0, 250);
                    totalPoints += random.Next(1, 25);
                }
                Console.WriteLine("Points: " + totalPoints);
                Console.WriteLine("Progress: " + totalSteps + "/" + maxSteps);
                Console.WriteLine();

                Thread.Sleep(1000);
            }
            Stop();
        }

        // evaluate end state
        public void Stop()
        {
            Console.WriteLine("Total points: " + totalPoints);
            if (totalPoints > pointThreshold)
            {
                prize = factory.createGadget();
                Console.WriteLine("You won a " + prize.GetType().Name + "!!!");
                prize.doStuff();
            }
            else
            {
                Console.WriteLine("You lost the game :(");
            }
            Console.ReadKey();
        }

    }
}