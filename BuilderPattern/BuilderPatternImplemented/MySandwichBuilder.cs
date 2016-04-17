using System.Collections.Generic;

namespace BuilderPatternImplemented
{
    /// <summary>
    /// Concrete Builder
    /// </summary>
    internal class MySandwichBuilder : SandwichBuilder
    {
        public void CreateSandwich()
        {
            sandwich = new Sandwich();

            PrepareBread();
            ApplyMeatAndCheese();
            ApplyVegetables();
            AddCondiments();
        }

        public override void AddCondiments()
        {
            sandwich.HasMayo = false;
            sandwich.IsToasted = true;
            sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Turkey;
            sandwich.CheeseType = CheeseType.Cheddar;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
        }
    }
}