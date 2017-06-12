using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    class StockSubject : Subject
    {
        private string state = "Invalid";

        public void SetState(string s)
        {
            state = s;
        }

        public string GetState()
        {
            return state;
        }
    }
}
