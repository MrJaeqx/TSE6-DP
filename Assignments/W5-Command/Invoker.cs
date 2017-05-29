using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W5_Command
{
    class Invoker
    {
        private List<ICallback> calculations = new List<ICallback>();

        public void queueCalculation(ICallback calculation)
        {
            calculations.Add(calculation);
        }

        public void doCalculations()
        {
            foreach (ICallback args in calculations)
            {
                args.execute();
            }
        }
    }
}
