using System.Collections.Generic;

namespace AnyVsContains.Algorithms
{
    public interface ISearchAlgorithm
    {
        bool Search<T>(IEnumerable<T> source, T value);
    }
}
