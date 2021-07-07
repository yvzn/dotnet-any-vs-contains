using System.Collections.Generic;
using System.Diagnostics;
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
    public class BenchmarksForCollections
    {
        [Params(TypeOfData.Integer, TypeOfData.String, TypeOfData.Record)]
        public TypeOfData Type;

        [Params(100, 10_000, 1_000_000)]
        public int N;

        [Params(TypeOfCollection.Array, TypeOfCollection.List, TypeOfCollection.HashSet)]
        public TypeOfCollection Coll;

        private readonly Benchmark<int, GeneratorOfIntegers> benchmarkOfIntegers = new Benchmark<int, GeneratorOfIntegers>();
        private readonly Benchmark<string, GeneratorOfStrings> benchmarkOfStrings = new Benchmark<string, GeneratorOfStrings>();
        private readonly Benchmark<Contract, GeneratorOfRecords> benchmarkOfRecords = new Benchmark<Contract, GeneratorOfRecords>();

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
        }

        [Benchmark]
        public void CreateCollections()
        {
            switch (Type)
            {
                case TypeOfData.Integer:
                    benchmarkOfIntegers.RunBenchmark();
                    break;

                case TypeOfData.String:
                    benchmarkOfStrings.RunBenchmark();
                    break;

                case TypeOfData.Record:
                    benchmarkOfRecords.RunBenchmark();
                    break;
            }
        }

        private class Benchmark<TValue, TGenerator> where TGenerator : IGenerator<TValue>, new()
        {
            private IEnumerable<TValue> dataset;
            private TypeOfCollection typeOfCollection;

            public void Setup(TypeOfCollection typeOfCollection, int numberOfValues)
            {
                this.typeOfCollection = typeOfCollection;
                var datasetGenerator = new TGenerator();
                dataset = datasetGenerator.GetDataset(numberOfValues);
            }

            public ICollection<TValue> RunBenchmark()
            {
                var collection = CollectionsFactory.Create(typeOfCollection, dataset);
                Debug.Assert(collection.Count > 0);
                return collection;
            }
        }
    }
}
