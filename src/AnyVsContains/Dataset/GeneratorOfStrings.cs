namespace AnyVsContains.Dataset
{
    internal class GeneratorOfStrings : Generator<string>
    {
        public override string GetSearchPositiveItem()
        {
            return "needle";
        }

        private protected override string GetSearchNegativeItem(int index)
        {
            return random.Next().ToString("x");
        }
    }
}
