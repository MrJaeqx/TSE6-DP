using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Command
{
    public class Receiver
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));;
        }

        public void Substract(int a, int b)
        {
            Console.WriteLine(a + " - " + b + " = " + (a - b)); ;
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a + " * " + b + " = " + (a * b)); ;
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(a + " / " + b + " = " + (a / b)); ;
        }
    }
}
