using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new Sandwich(BreadType.Wheat, false, CheeseType.American, MeatType.Turkey, false, false, new List<string> { "Tomato" }).Display();
            //// more readable making it easier to construct
            //// hard to keep track on what is set or not
            //// ordering here can be jumbled, order is critical
            //var sandwich = new Sandwich();
            //sandwich.BreadType = BreadType.White;
            //sandwich.CheeseType = CheeseType.Cheddar;
            //sandwich.HasMayo = false;
            //sandwich.IsToasted = true;
            //sandwich.HasMustard = true;
            //sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
            //sandwich.Display();
            Console.ReadKey();
        }
    }
}