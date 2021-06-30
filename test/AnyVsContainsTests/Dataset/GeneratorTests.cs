using AnyVsContains.Dataset;
using FluentAssertions;
using Xunit;

namespace AnyVsContainsTests.Dataset
{
    public class TestedAlgorithms : TheoryData<IGenerator>
    {
        public TestedAlgorithms()
        {
            Add(new GeneratorOfIntegers());
            Add(new GeneratorOfStrings());
            Add(new GeneratorOfRecords());
        }
    }

    public class GeneratorTests
    {
        public class Method
        {
            [Theory]
            [ClassData(typeof(TestedAlgorithms))]
            public void Should_return_given_number_of_items(IGenerator generator)
            {
                // Given
                var count = 100;

                // When
                var actual = generator.GetDataset(count);

                // Then
                actual.Should().HaveCount(count);
            }

            [Theory]
            [ClassData(typeof(TestedAlgorithms))]
            public void Should_contain_one_instance_of_searched_item(IGenerator generator)
            {
                // Given
                var count = 100;
                var searched = generator.GetSearchPositive();

                // When
                var actual = generator.GetDataset(count);

                // Then
                actual.Should().Contain(searched);
            }
        }
    }
}
