using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * This week's sample will be about a car dealership.
 */

namespace W4_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car regularCar = new Car();
            Airco aircoCar = new Airco(regularCar);
            Stereo stereoCar = new Stereo(regularCar);
            Stereo bothOptions = new Stereo(aircoCar); //  why doesn't this work???

            System.Console.WriteLine("Regular car price: " + regularCar.GetPrice() + "\n");
            System.Console.WriteLine("\t\t " + regularCar.GetDescription() + "\n");

            System.Console.WriteLine("Regular car /w airco: " + aircoCar.GetPrice() + "\n");
            System.Console.WriteLine("\t\t " + aircoCar.GetDescription() + "\n");

            System.Console.WriteLine("Regular car /w stereo: " + stereoCar.GetPrice() + "\n");
            System.Console.WriteLine("\t\t " + stereoCar.GetDescription() + "\n");

            System.Console.WriteLine("Regular car /w both: " + bothOptions.GetPrice() + "\n");
            System.Console.WriteLine("\t\t " + bothOptions.GetDescription() + "\n");



            Console.ReadLine();
        }
    }
}
