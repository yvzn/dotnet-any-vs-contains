using System.Collections.Generic;
using System.Diagnostics;
using AnyVsContains.Algorithms;
using AnyVsContains.Collections;
using AnyVsContains.Dataset;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace AnyVsContainsBenchmark
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    [CsvExporter]
    [HtmlExporter]
    public class Benchmarks
    {
        [Params(TypeOfData.Integer, TypeOfData.String, TypeOfData.Record)]
        public TypeOfData Type;

        [Params(100, 10_000, 1_000_000)]
        public int N;

        [Params(TypeOfCollection.Array, TypeOfCollection.List, TypeOfCollection.HashSet)]
        public TypeOfCollection Coll;

        [Params(TypeOfAlgorithm.Any, TypeOfAlgorithm.Contains)]
        public TypeOfAlgorithm Algo;

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
        public void AnyVsContains()
        {
            switch (Type)
            {
                case TypeOfData.Integer:
                    RunBenchmark(integerDataset, integerSearchPositive);
                    break;

                case TypeOfData.String:
                    RunBenchmark(stringDataset, stringSearchPositive);
                    break;

                case TypeOfData.Record:
                    RunBenchmark(recordDataset, recordSearchPositive);
                    break;
            }
        }

        private void RunBenchmark<T>(IEnumerable<T> dataset, T searchPositive)
        {
            var sourceCollection = CollectionsFactory.Create(Coll, dataset);
            var found = searchAlgorithm.Search(sourceCollection, searchPositive);
            Debug.Assert(found);
        }
    }
}
