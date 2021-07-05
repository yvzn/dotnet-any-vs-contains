using System;
using AnyVsContains.Dataset;
using FluentAssertions;
using Xunit;

namespace AnyVsContainsTests.Dataset
{
    public class TestedGenerators : TheoryData<IGenerator>
    {
        public TestedGenerators()
        {
            Add(new GeneratorOfIntegers());
            Add(new GeneratorOfStrings());
            Add(new GeneratorOfRecords());
        }
    }

    public class GeneratorTests
    {
        public class GetDataset
        {
            [Theory]
            [ClassData(typeof(TestedGenerators))]
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
            [ClassData(typeof(TestedGenerators))]
            public void Should_contain_one_instance_of_searched_item(IGenerator generator)
            {
                // Given
                var count = 20;
                var searched = generator.GetSearchPositive();

                // When
                var actual = generator.GetDataset(count);

                // Then
                actual.Should().Contain(searched);
            }
        }
    }
}
