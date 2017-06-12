using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Int32;


namespace W5_Command
{
    class Program
    {
        static readonly List<char> SupportedOperators = new List<char>(new char[]
        {
            '+', '-', '*', '/'
        });

        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();

            Console.WriteLine("Type your calculation with two arguments.");
            Console.WriteLine("+, -, * and / are supported operators.");
            Console.WriteLine("Three empty lines will stop the program and show results.");


            double arg1, arg2;

            string calcOperator = "";

            while (calcOperator != "stop")
            {
                calcOperator = CalcOperator(out arg1, out arg2);
                switch (calcOperator)
                {
                    case "+":
                        invoker.queueCalculation(new Add(receiver, arg1, arg2));
                        break;
                    case "-":
                        invoker.queueCalculation(new Substract(receiver, arg1, arg2));
                        break;
                    case "*":
                        invoker.queueCalculation(new Multiply(receiver, arg1, arg2));
                        break;
                    case "/":
                        invoker.queueCalculation(new Divide(receiver, arg1, arg2));
                        break;
                }
            }
            
            invoker.doCalculations();
            Console.ReadLine();
        }

        private static string CalcOperator(out double arg1, out double arg2)
        {
            string calcOperator;
            bool correctParse = false;
            bool validOperator = false;
            do
            {
                Console.Write("Argument 1: ");
                string rawarg1 = Console.ReadLine();

                Console.Write("Operator:   ");
                calcOperator = Console.ReadLine();

                Console.Write("Argument 2: ");
                string rawarg2 = Console.ReadLine();

                if (rawarg1 + calcOperator + rawarg2 == "")
                {
                    arg1 = 0;
                    arg2 = 0;
                    return "stop";
                }

                foreach (char op in SupportedOperators)
                {
                    if (calcOperator == op.ToString())
                        validOperator = true;
                }
                
                bool arg1Correct = double.TryParse(rawarg1, out arg1);
                bool arg2Correct = double.TryParse(rawarg2, out arg2);
                
                if (arg1Correct && arg2Correct)
                {
                    correctParse = true;
                }

                if (!correctParse || !validOperator)
                {
                    Console.WriteLine("Syntax error");
                }
                else
                {
                    Console.WriteLine("Added operation");
                }
            } while (!correctParse || !validOperator);


            return calcOperator;
        }
    }
}
