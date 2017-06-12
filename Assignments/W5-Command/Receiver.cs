using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Command
{
    public class Receiver
    {
        public void Add(double a, double b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));;
        }

        public void Substract(double a, double b)
        {
            Console.WriteLine(a + " - " + b + " = " + (a - b)); ;
        }

        public void Multiply(double a, double b)
        {
            Console.WriteLine(a + " * " + b + " = " + (a * b)); ;
        }

        public void Divide(double a, double b)
        {
            Console.WriteLine(a + " / " + b + " = " + (a / b)); ;
        }
    }
}
