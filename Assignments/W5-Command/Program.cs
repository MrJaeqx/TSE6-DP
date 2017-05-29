using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            int a = 3;
            int b = 2;

            invoker.queueCalculation(new Add(receiver, a, b));
            invoker.queueCalculation(new Substract(receiver, a, b));
            invoker.queueCalculation(new Multiply(receiver, a, b));
            invoker.queueCalculation(new Divide(receiver, a, b));

            invoker.doCalculations();
            Console.ReadLine();
        }
    }
}
