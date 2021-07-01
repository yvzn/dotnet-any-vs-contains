using System.Collections.Generic;
using System.Linq;

namespace AnyVsContains.Algorithms
{
    internal class AlgorithmContains : ISearchAlgorithm
    {
        public bool Search<T>(IEnumerable<T> source, T value) => source.Contains(value);
    }
}
