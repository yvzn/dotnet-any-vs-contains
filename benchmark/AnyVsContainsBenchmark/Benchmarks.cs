using System.Collections.Generic;
using System.Diagnostics;
using AnyVsContains.Algorithms;
using AnyVsContains.Collections;
using AnyVsContains.Dataset;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace AnyVsContainsBenchmark
{
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    public class Benchmarks
    {
        [Params(TypeOfCollection.Array, TypeOfCollection.List, TypeOfCollection.HashSet)]
        public TypeOfCollection Coll;

        [Params(TypeOfAlgorithm.Any, TypeOfAlgorithm.Contains)]
        public TypeOfAlgorithm Algo;

        [Params(100, 10_000, 1_000_000)]
        public int N;

        private IEnumerable<int> integerDataset;
        private int integerSearchPositive;

        private IEnumerable<string> stringDataset;
        private string stringSearchPositive;

        private IEnumerable<Contract> recordDataset;
        private Contract recordSearchPositive;

        private ISearchAlgorithm searchAlgorithm;

        [GlobalSetup]
        public void Setup()
        {
            var generatorOfIntegers = new GeneratorOfIntegers();
            integerDataset = generatorOfIntegers.GetDataset(N);
            integerSearchPositive = generatorOfIntegers.GetSearchPositive();

            var generatorOfStrings = new GeneratorOfStrings();
            stringDataset = generatorOfStrings.GetDataset(N);
            stringSearchPositive = generatorOfStrings.GetSearchPositive();

            var generatorOfRecords = new GeneratorOfRecords();
            recordDataset = generatorOfRecords.GetDataset(N);
            recordSearchPositive = generatorOfRecords.GetSearchPositive();

            searchAlgorithm = SearchAlgorithmFactory.Create(Algo);
        }

        [Benchmark]
        public void Integers()
        {
            RunBenchmark(integerDataset, integerSearchPositive);
        }

        [Benchmark]
        public void Strings()
        {
            RunBenchmark(stringDataset, stringSearchPositive);
        }

        [Benchmark]
        public void Records()
        {
            RunBenchmark(recordDataset, recordSearchPositive);
        }

        private void RunBenchmark<T>(IEnumerable<T> dataset, T searchPositive)
        {
            var sourceCollection = CollectionsFactory.Create(Coll, dataset);
            var found = searchAlgorithm.Search(sourceCollection, searchPositive);
            Debug.Assert(found);
        }
    }
}
