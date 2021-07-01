using System;

namespace AnyVsContains.Algorithms
{
    public class SearchAlgorithmFactory
    {
        public static ISearchAlgorithm Create(TypeOfAlgorithm type) =>
            type switch
            {
                TypeOfAlgorithm.Any => new AlgorithmAny(),
                TypeOfAlgorithm.Contains => new AlgorithmContains(),
                _ => throw new ArgumentOutOfRangeException(nameof(type)),
            };
    }
}
