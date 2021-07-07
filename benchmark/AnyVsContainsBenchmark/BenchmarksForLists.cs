using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
    public class BenchmarksForLists
    {
        [Params(TypeOfData.Integer, TypeOfData.String, TypeOfData.Record)]
        public TypeOfData Type;

        [Params(100, 10_000, 1_000_000)]
        public int N;

        private readonly Benchmark<int, GeneratorOfIntegers> benchmarkOfIntegers = new Benchmark<int, GeneratorOfIntegers>();
        private readonly Benchmark<string, GeneratorOfStrings> benchmarkOfStrings = new Benchmark<string, GeneratorOfStrings>();
        private readonly Benchmark<Contract, GeneratorOfRecords> benchmarkOfRecords = new Benchmark<Contract, GeneratorOfRecords>();

        [GlobalSetup]
        public void Setup()
        {
            switch (Type)
            {
                case TypeOfData.Integer:
                    benchmarkOfIntegers.Setup(N);
                    break;

                case TypeOfData.String:
                    benchmarkOfStrings.Setup(N);
                    break;

                case TypeOfData.Record:
                    benchmarkOfRecords.Setup(N);
                    break;
            }
        }

        [Benchmark]
        public void Any()
        {
            static bool SearchAlgorithm<T>(List<T> searchList, T searchPositive)
            {
                return searchList.Any(item => searchPositive.Equals(item));
            }

            switch (Type)
            {
                case TypeOfData.Integer:
                    benchmarkOfIntegers.RunBenchmark(SearchAlgorithm);
                    break;

                case TypeOfData.String:
                    benchmarkOfStrings.RunBenchmark(SearchAlgorithm);
                    break;

                case TypeOfData.Record:
                    benchmarkOfRecords.RunBenchmark(SearchAlgorithm);
                    break;
            }
        }

        [Benchmark]
        public void Contains()
        {
            static bool SearchAlgorithm<T>(List<T> searchList, T searchPositive)
            {
                return searchList.Contains(searchPositive);
            }

            switch (Type)
            {
                case TypeOfData.Integer:
                    benchmarkOfIntegers.RunBenchmark(SearchAlgorithm);
                    break;

                case TypeOfData.String:
                    benchmarkOfStrings.RunBenchmark(SearchAlgorithm);
                    break;

                case TypeOfData.Record:
                    benchmarkOfRecords.RunBenchmark(SearchAlgorithm);
                    break;
            }
        }

        [Benchmark]
        public void Exists()
        {
            static bool SearchAlgorithm<T>(List<T> searchList, T searchPositive)
            {
                return searchList.Exists(item => searchPositive.Equals(item));
            }

            switch (Type)
            {
                case TypeOfData.Integer:
                    benchmarkOfIntegers.RunBenchmark(SearchAlgorithm);
                    break;

                case TypeOfData.String:
                    benchmarkOfStrings.RunBenchmark(SearchAlgorithm);
                    break;

                case TypeOfData.Record:
                    benchmarkOfRecords.RunBenchmark(SearchAlgorithm);
                    break;
            }
        }

        private class Benchmark<TValue, TGenerator> where TGenerator : IGenerator<TValue>, new()
        {
            private TGenerator datasetGenerator;
            private List<TValue> collection;
            private TValue searchPositive;

            internal delegate bool SearchAlgorithm(List<TValue> searchList, TValue searchPositive);

            public void Setup(int numberOfValues)
            {
                datasetGenerator = new TGenerator();
                collection = datasetGenerator.GetDataset(numberOfValues).ToList();
                searchPositive = datasetGenerator.GetSearchPositive();
            }

            public void RunBenchmark(SearchAlgorithm searchAlgorithm)
            {
                var found = searchAlgorithm.Invoke(collection, searchPositive);
                Debug.Assert(found);
            }
        }
    }
}
