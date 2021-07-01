using System.Collections.Generic;
using System.Linq;

namespace AnyVsContains.Algorithms
{
    internal class AlgorithmAny : ISearchAlgorithm
    {
        public bool Search<T>(IEnumerable<T> source, T value) => source.Any(item => item.Equals(value));
    }
}
