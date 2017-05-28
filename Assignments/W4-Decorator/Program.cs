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
            RegularCar regularCar = new RegularCar();
            System.Console.WriteLine("1: " + regularCar.GetDescription());
            System.Console.WriteLine("$: " + regularCar.GetPrice());

            Airco aircoCar = new Airco(regularCar);
            System.Console.WriteLine("2: " + aircoCar.GetDescription());
            System.Console.WriteLine("$: " + aircoCar.GetPrice());

            Stereo stereoCar = new Stereo(regularCar);
            System.Console.WriteLine("3: " + stereoCar.GetDescription());
            System.Console.WriteLine("$: " + stereoCar.GetPrice());

            Airco stereoAircoCar = new Airco(stereoCar);
            System.Console.WriteLine("4: " + stereoAircoCar.GetDescription());
            System.Console.WriteLine("$: " + stereoAircoCar.GetPrice());

            Console.ReadLine();
        }
    }
}
