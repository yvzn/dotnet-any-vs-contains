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

        private IEnumerable<int> integerDataset;
        private IEnumerable<string> stringDataset;
        private IEnumerable<Contract> recordDataset;

        [GlobalSetup]
        public void Setup()
        {
            switch (Type)
            {
                case TypeOfData.Integer:
                    var generatorOfIntegers = new GeneratorOfIntegers();
                    integerDataset = generatorOfIntegers.GetDataset(N);
                    break;

                case TypeOfData.String:
                    var generatorOfStrings = new GeneratorOfStrings();
                    stringDataset = generatorOfStrings.GetDataset(N);
                    break;

                case TypeOfData.Record:
                    var generatorOfRecords = new GeneratorOfRecords();
                    recordDataset = generatorOfRecords.GetDataset(N);
                    break;
            }
        }

        [Benchmark]
        public void CreateCollections()
        {
            switch (Type)
            {
                case TypeOfData.Integer:
                    RunBenchmark(Coll, integerDataset);
                    break;

                case TypeOfData.String:
                    RunBenchmark(Coll, stringDataset);
                    break;

                case TypeOfData.Record:
                    RunBenchmark(Coll, recordDataset);
                    break;
            }
        }

        private void RunBenchmark<T>(TypeOfCollection type, IEnumerable<T> dataset)
        {
            var collection = CollectionsFactory.Create(type, dataset);
            Debug.Assert(collection.Count > 0);
        }
    }
}
