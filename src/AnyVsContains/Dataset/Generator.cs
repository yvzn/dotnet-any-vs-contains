using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AnyVsContains.Dataset
{
    abstract public class Generator<T> : IGenerator<T>, IGenerator
    {
        // random with constant seed, for reproductibility
        protected readonly Random random = new Random(Seed: 20210620);

        public IEnumerable<T> GetDataset(int count)
        {
            return GetItems(count).OrderBy(_ => random.Next());
        }

        IEnumerable IGenerator.GetDataset(int count) => GetDataset(count);

        private IEnumerable<T> GetItems(int count)
        {
            if (count == 0) yield break;

            yield return GetSearchPositive();
            for (int index = 1; index < count; index++)
            {
                yield return GetSearchNegative(index);
            }
        }

        abstract public T GetSearchPositive();

        object IGenerator.GetSearchPositive() => GetSearchPositive();

        abstract protected private T GetSearchNegative(int index);
    }
}
