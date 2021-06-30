namespace AnyVsContains.Dataset
{
    internal class GeneratorOfIntegers : Generator<int>
    {
        public override int GetSearchPositiveItem()
        {
            return -1;
        }

        private protected override int GetSearchNegativeItem(int index)
        {
            return random.Next();
        }
    }
}
