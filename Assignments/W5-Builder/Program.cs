using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PCBuilder builder = null;
            PCShop shop = new PCShop();

            Console.WriteLine("Welcome to Lars & MT PCMarkt(TM)(R)(C)");

            int choice;
            List<int> validOptions = new List<int> {1, 2};

            while (true)
            {
                builder = null;
                Console.WriteLine("Available PC options:");
                Console.WriteLine("1. Desktop");
                Console.WriteLine("2. Laptop");
                Console.WriteLine("Select a PC!");
                while (!Int32.TryParse(Console.ReadLine(), out choice) || !validOptions.Contains(choice))
                {
                    Console.WriteLine("Try again!");
                }

                switch (choice)
                {
                    case 1:
                        {
                            builder = new DesktopBuilder();
                            break;
                        }
                    case 2:
                        {
                            builder = new LaptopBuilder();
                            break;
                        }
                    // No default because we can only accept 1 or 2!
                }
                shop.BuildPC(builder);
                builder.PC.Show();
                Console.WriteLine("Press Escape to stop, or any other key to continue!");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
