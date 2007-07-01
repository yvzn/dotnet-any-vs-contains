namespace AnyVsContains.Dataset
{
    public class GeneratorOfIntegers : Generator<int>
    {
        public override int GetSearchPositive()
        {
            return -1;
        }

        private protected override int GetSearchNegative(int index)
        {
            return random.Next();
        }
    }
}
