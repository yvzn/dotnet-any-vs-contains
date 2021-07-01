﻿namespace AnyVsContains.Dataset
{
    internal class GeneratorOfStrings : Generator<string>
    {
        public override string GetSearchPositive()
        {
            return "needle";
        }

        private protected override string GetSearchNegative(int index)
        {
            return random.Next().ToString("x");
        }
    }
}
