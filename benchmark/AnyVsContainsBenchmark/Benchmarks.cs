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

        private readonly Benchmark<int, GeneratorOfIntegers> benchmarkOfIntegers = new Benchmark<int, GeneratorOfIntegers>();
        private readonly Benchmark<string, GeneratorOfStrings> benchmarkOfStrings = new Benchmark<string, GeneratorOfStrings>();
        private readonly Benchmark<Contract, GeneratorOfRecords> benchmarkOfRecords = new Benchmark<Contract, GeneratorOfRecords>();

        private ISearchAlgorithm searchAlgorithm;

        [GlobalSetup]
        public void Setup()
        {
            switch (Type)
            {
                case TypeOfData.Integer:
                    benchmarkOfIntegers.Setup(Coll, N);
                    break;

                case TypeOfData.String:
                    benchmarkOfStrings.Setup(Coll, N);
                    break;

                case TypeOfData.Record:
                    benchmarkOfRecords.Setup(Coll, N);
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
                    benchmarkOfIntegers.RunBenchmark(searchAlgorithm);
                    break;

                case TypeOfData.String:
                    benchmarkOfStrings.RunBenchmark(searchAlgorithm);
                    break;

                case TypeOfData.Record:
                    benchmarkOfRecords.RunBenchmark(searchAlgorithm);
                    break;
            }
        }

        private class Benchmark<TValue, TGenerator> where TGenerator : IGenerator<TValue>, new()
        {
            private TGenerator datasetGenerator;
            private ICollection<TValue> collection;
            private TValue searchPositive;

            public void Setup(TypeOfCollection typeOfCollection, int numberOfValues)
            {
                datasetGenerator = new TGenerator();
                collection = CollectionsFactory.Create(typeOfCollection, datasetGenerator.GetDataset(numberOfValues));
                searchPositive = datasetGenerator.GetSearchPositive();
            }

            public void RunBenchmark(ISearchAlgorithm searchAlgorithm)
            {
                var found = searchAlgorithm.Search(collection, searchPositive);
                Debug.Assert(found);
            }
        }
    }
}
