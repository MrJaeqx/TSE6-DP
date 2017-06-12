using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using W4_Decorator.Decorators;

/*
 * This week's sample will be about a car dealership.
 * 
 * We had some difficulties with the decorators not concatenating
 * properly, which was caused by not having the abstract class method
 * being "virtual" with the concrete class method being "override".
 */

namespace W4_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICar> baseCars = new List<ICar>();
            List<CarDecorator> decorators = new List<CarDecorator>();

            baseCars.Add(new AudiA3());
            baseCars.Add(new BMWX3());
            baseCars.Add(new MitsubishiLancerEVO6());
            baseCars.Add(new FordTaunus());
            baseCars.Add(new VolkswagenBeetle());

            int i = 0;
            foreach (ICar car in baseCars)
            {
                Console.WriteLine("{0, -32}{1, 10}", i + ". "+ car.GetDescription(), "$" + car.GetPrice());
                i++;
            }

            int carChoice;
            bool correctCar = false;
            do
            {
                Console.WriteLine("Press a number to select a car.");
                ConsoleKeyInfo key = Console.ReadKey();
                if (!Int32.TryParse(key.KeyChar.ToString(), out carChoice) || carChoice >= baseCars.Count)
                {
                    Console.WriteLine("Invalid choice, try again");
                }
                else
                {
                    correctCar = true;
                }
            } while (!correctCar);
           
            ICar selectedCar = baseCars[carChoice];

            decorators.Add(new Airco(selectedCar));
            decorators.Add(new BikeRack(selectedCar));
            decorators.Add(new Navigation(selectedCar));
            decorators.Add(new RallyEdition(selectedCar));
            decorators.Add(new Stereo(selectedCar));
            decorators.Add(new Towhook(selectedCar));

            int options = 0;
            while (true)
            {
                List<CarDecorator> newDecorators = new List<CarDecorator>();
                newDecorators.Add(new Airco(selectedCar));
                newDecorators.Add(new BikeRack(selectedCar));
                newDecorators.Add(new Navigation(selectedCar));
                newDecorators.Add(new RallyEdition(selectedCar));
                newDecorators.Add(new Stereo(selectedCar));
                newDecorators.Add(new Towhook(selectedCar));

                Console.Clear();
                i = 0;
                foreach (CarDecorator decorator in decorators)
                {
                    Console.WriteLine("{0, -48}{1, 20}", i + ". " + decorator.GetDescription(), "$" + decorator.GetPrice());
                    i++;
                }
                Console.WriteLine("Current choice: " + selectedCar.GetDescription() + " $" + selectedCar.GetPrice());
                Console.WriteLine("Press a number to select an option, or Enter to check out.");
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape || key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                int decoratorChoice;
                if (!Int32.TryParse(key.KeyChar.ToString(), out decoratorChoice) || decoratorChoice >= decorators.Count)
                {
                    Console.WriteLine("Invalid choice, try again");
                    continue;
                }
                selectedCar = newDecorators[decoratorChoice];
                options++;
            }

            Console.Clear();
            Console.WriteLine("Your total:");
            Console.WriteLine("{0, -32}{1, 10}", i + ". " + selectedCar.GetDescription(), "$" + selectedCar.GetPrice());

            Console.ReadLine();
        }
    }
}
