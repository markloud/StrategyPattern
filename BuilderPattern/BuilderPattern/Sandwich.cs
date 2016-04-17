using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Sandwich
    {
        private readonly BreadType BreadType;
        private readonly bool IsToasted;
        private readonly CheeseType CheeseType;
        private readonly MeatType MeatType;
        private readonly bool HasMustard;
        private readonly bool HasMayo;
        private readonly List<string> Vegetables;

        //public BreadType BreadType { get; set; }
        //public bool IsToasted { get; set; }
        //public CheeseType CheeseType { get; set; }
        //public MeatType MeatType { get; set; }
        //public bool HasMustard { get; set; }
        //public bool HasMayo { get; set; }
        //public List<string> Vegetables { get; set; }

        //Constructor can be a real mess when we have a multiple constructor imlementation
        public Sandwich(BreadType breadType, bool isToasted, CheeseType cheeseType, MeatType meatType, bool hasMustard, bool hasMayo, List<string> vegetables)
        {
            BreadType = breadType;
            IsToasted = isToasted;
            CheeseType = cheeseType;
            MeatType = meatType;
            HasMustard = hasMustard;
            HasMayo = hasMayo;
            Vegetables = vegetables;
        }

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

    enum BreadType
    {
        Wheat,
        White
    }

    enum CheeseType
    {
        American,
        Swiss,
        Cheddar,
        Eden
    }

    enum MeatType
    {
        Turkey,
        Ham,
        Chicken,
        Salami
    }
}
