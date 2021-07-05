using AnyVsContains.Algorithms;
using FluentAssertions;
using Xunit;

namespace AnyVsContainsTests.Algorithms
{
    public class TestedSearchAlgorithms : TheoryData<ISearchAlgorithm>
    {
        public TestedSearchAlgorithms()
        {
            Add(new AlgorithmAny());
            Add(new AlgorithmContains());
        }
    }

    public class ISearchAlgorithmTests
    {
        public class Search
        {
            [Theory]
            [ClassData(typeof(TestedSearchAlgorithms))]
            public void Should_return_true_for_search_positive(ISearchAlgorithm searchAlgorithm)
            {
                // Given
                var source = new[] { 1, 2, 3, 4 };
                var value = 1;

                // When
                var actual = searchAlgorithm.Search(source, value);

                // Then
                actual.Should().BeTrue();
            }

            [Theory]
            [ClassData(typeof(TestedSearchAlgorithms))]
            public void Should_return_false_for_search_negative(ISearchAlgorithm searchAlgorithm)
            {
                // Given
                var source = new[] { 1, 2, 3, 4 };
                var value = -1;

                // When
                var actual = searchAlgorithm.Search(source, value);

                // Then
                actual.Should().BeFalse();
            }
        }
    }
}
