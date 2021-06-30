using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AnyVsContains.Dataset
{
    abstract internal class Generator<T> : IGenerator
    {
        // random with constant seed, for reproductibility
        protected readonly Random random = new(Seed: 20210620);

        public IEnumerable GetDataset(int count)
        {
            return GetItems(count).OrderBy(_ => random.Next());
        }

        private IEnumerable<T> GetItems(int count)
        {
            if (count == 0) yield break;

            yield return (T)GetSearchPositive();
            for (int index = 1; index < count; index++)
            {
                yield return GetSearchNegativeItem(index);
            }
        }

        public object GetSearchPositive() => GetSearchPositiveItem();

        abstract public T GetSearchPositiveItem();

        abstract protected private T GetSearchNegativeItem(int index);
    }
}
