namespace BuilderPatternImplemented
{
    // has the process of making the sandwich no matter what type it is
    /// <summary>
    /// Director
    /// </summary>
    internal class SandwichMaker
    {
        private readonly SandwichBuilder Builder;

        public SandwichMaker(SandwichBuilder builder)
        {
            Builder = builder;
        }

        public void BuildSandwich()
        {
            Builder.CreateNewSandwich();
            Builder.PrepareBread();
            Builder.ApplyMeatAndCheese();
            Builder.ApplyVegetables();
            Builder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return Builder.GetSandwich();
        }
    }
}