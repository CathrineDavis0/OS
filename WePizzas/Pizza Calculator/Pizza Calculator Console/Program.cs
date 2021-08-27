using System;
using System.Collections.Generic;

namespace Pizza_Calculator_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaCalculator calculator = new PizzaCalculator();
            List<string> toppings = calculator.GetToppingsFor("margarita");


            Printer printer = new Printer();
            string pizzaToppings = printer.PrintToppings(toppings);
            Console.WriteLine(pizzaToppings);
        }
    }
}
