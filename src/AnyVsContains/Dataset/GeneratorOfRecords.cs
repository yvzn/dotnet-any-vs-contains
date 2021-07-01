﻿namespace AnyVsContains.Dataset
{
    internal class GeneratorOfRecords : Generator<Contract>
    {
        public override Contract GetSearchPositive()
        {
            return new("needle", "propA", "propB", -1);
        }

        private protected override Contract GetSearchNegative(int index)
        {
            return new(random.Next().ToString("x"), random.Next().ToString("x"), random.Next().ToString("x"), random.Next());
        }
    }

    internal record Contract(string Reference, string PropertyA, string PropertyB, int PropertyC);
}
