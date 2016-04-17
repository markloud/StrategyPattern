using System;

namespace BuilderPatternImplemented
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sandwichMaker = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker.BuildSandwich();
            var sandwich1 = sandwichMaker.GetSandwich();
            sandwich1.Display();

            var sandwichMaker2 = new SandwichMaker(new MySandwichBuilder());
            sandwichMaker2.BuildSandwich();
            var sandwich2 = sandwichMaker.GetSandwich();
            sandwich1.Display();

            Console.ReadKey();
        }
    }
}