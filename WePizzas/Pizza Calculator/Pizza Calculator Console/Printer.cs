using System;
using System.Collections.Generic;

namespace Pizza_Calculator_Console
{
    public class Printer
    {
        public string PrintToppings(List<string> toppings)
        {
            string toppingsString = string.Join(", ", toppings);
            string ultimateString = $"Toppings: {toppingsString}";
            return ultimateString;
        }
    }
}