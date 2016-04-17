using System;
using System.Collections.Generic;

namespace BuilderPatternImplemented
{
    /// <summary>
    /// The Product
    /// </summary>
    internal class Sandwich
    {
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine("----- ORDER -----\n@ Sandwich on {0} bread", BreadType);
            if (IsToasted)
                Console.WriteLine("-Toasted");
            if (HasMayo)
                Console.WriteLine("-Has Mayo");
            if (HasMustard)
                Console.WriteLine("-Has Mustard");
            Console.WriteLine("-Meat: {0}", MeatType);
            Console.WriteLine("-Cheese: {0}", CheeseType);
            Console.WriteLine("-Veggies:");
            foreach (var vegetable in Vegetables)
                Console.WriteLine("\t+{0}", vegetable);
        }
    }

    internal enum BreadType
    {
        Wheat,
        White
    }

    internal enum CheeseType
    {
        American,
        Swiss,
        Cheddar,
        Eden
    }

    internal enum MeatType
    {
        Turkey,
        Ham,
        Chicken,
        Salami
    }
}