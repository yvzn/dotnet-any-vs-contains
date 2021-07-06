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

        private ICollection<int> integerCollection;
        private int integerSearchPositive;

        private ICollection<string> stringCollection;
        private string stringSearchPositive;

        private ICollection<Contract> recordCollection;
        private Contract recordSearchPositive;

        private ISearchAlgorithm searchAlgorithm;

        [GlobalSetup]
        public void Setup()
        {
            switch (Type)
            {
                case TypeOfData.Integer:
                    var generatorOfIntegers = new GeneratorOfIntegers();
                    integerCollection = CollectionsFactory.Create(Coll, generatorOfIntegers.GetDataset(N));
                    integerSearchPositive = generatorOfIntegers.GetSearchPositive();
                    break;

                case TypeOfData.String:
                    var generatorOfStrings = new GeneratorOfStrings();
                    stringCollection = CollectionsFactory.Create(Coll, generatorOfStrings.GetDataset(N));
                    stringSearchPositive = generatorOfStrings.GetSearchPositive();
                    break;

                case TypeOfData.Record:
                    var generatorOfRecords = new GeneratorOfRecords();
                    recordCollection = CollectionsFactory.Create(Coll, generatorOfRecords.GetDataset(N));
                    recordSearchPositive = generatorOfRecords.GetSearchPositive();
                    break;
            }

            searchAlgorithm = SearchAlgorithmFactory.Create(Algo);
        }

        [Benchmark]
        public void AnyVsContains()
        {
            switch (Type)
            {
                case TypeOfData.Integer:
                    RunBenchmark(integerCollection, integerSearchPositive);
                    break;

                case TypeOfData.String:
                    RunBenchmark(stringCollection, stringSearchPositive);
                    break;

                case TypeOfData.Record:
                    RunBenchmark(recordCollection, recordSearchPositive);
                    break;
            }
        }

        private void RunBenchmark<T>(ICollection<T> sourceCollection, T searchPositive)
        {
            var found = searchAlgorithm.Search(sourceCollection, searchPositive);
            Debug.Assert(found);
        }
    }
}
