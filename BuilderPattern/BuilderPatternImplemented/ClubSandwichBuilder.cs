using System.Collections.Generic;

namespace BuilderPatternImplemented
{
    /// <summary>
    /// Concrete Builder
    /// </summary>
    internal class ClubSandwichBuilder : SandwichBuilder // logic is extracted, only data remains
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
            sandwich.IsToasted = true;
            sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Chicken;
            sandwich.CheeseType = CheeseType.Eden;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.Wheat;
        }
    }
}