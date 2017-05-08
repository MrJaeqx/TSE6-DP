using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    class StockState
    {
        private string data = "doe ff nie";

        public void SetStringThing(string s)
        {
            data = s;
        }

        public string GetStringThing()
        {
            return data;
        }
    }
}
