using System.Collections.Generic;
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
    public class BenchmarkForLists
    {
        [Params(TypeOfData.Integer, TypeOfData.String, TypeOfData.Record)]
        public TypeOfData Type;

        [Params(100, 10_000, 1_000_000)]
        public int N;

        private List<int> integerList;
        private int integerSearchPositive;

        private List<string> stringList;
        private string stringSearchPositive;

        private List<Contract> recordList;
        private Contract recordSearchPositive;

        [GlobalSetup]
        public void Setup()
        {
            switch (Type)
            {
                case TypeOfData.Integer:
                    var generatorOfIntegers = new GeneratorOfIntegers();
                    integerList = generatorOfIntegers.GetDataset(N).ToList();
                    integerSearchPositive = generatorOfIntegers.GetSearchPositive();
                    break;

                case TypeOfData.String:
                    var generatorOfStrings = new GeneratorOfStrings();
                    stringList = generatorOfStrings.GetDataset(N).ToList();
                    stringSearchPositive = generatorOfStrings.GetSearchPositive();
                    break;

                case TypeOfData.Record:
                    var generatorOfRecords = new GeneratorOfRecords();
                    recordList = generatorOfRecords.GetDataset(N).ToList();
                    recordSearchPositive = generatorOfRecords.GetSearchPositive();
                    break;
            }
        }

        [Benchmark]
        public void Any()
        {
            static bool RunBenchmark<T>(List<T> searchList, T searchPositive)
            {
                return searchList.Any(item => searchPositive.Equals(item));
            }

            switch (Type)
            {
                case TypeOfData.Integer:
                    RunBenchmark(integerList, integerSearchPositive);
                    break;

                case TypeOfData.String:
                    RunBenchmark(stringList, stringSearchPositive);
                    break;

                case TypeOfData.Record:
                    RunBenchmark(recordList, recordSearchPositive);
                    break;
            }
        }

        [Benchmark]
        public void Contains()
        {
            static bool RunBenchmark<T>(List<T> searchList, T searchPositive)
            {
                return searchList.Contains(searchPositive);
            }

            switch (Type)
            {
                case TypeOfData.Integer:
                    RunBenchmark(integerList, integerSearchPositive);
                    break;

                case TypeOfData.String:
                    RunBenchmark(stringList, stringSearchPositive);
                    break;

                case TypeOfData.Record:
                    RunBenchmark(recordList, recordSearchPositive);
                    break;
            }
        }

        [Benchmark]
        public void Exists()
        {
            static bool RunBenchmark<T>(List<T> searchList, T searchPositive)
            {
                return searchList.Exists(item => searchPositive.Equals(item));
            }

            switch (Type)
            {
                case TypeOfData.Integer:
                    RunBenchmark(integerList, integerSearchPositive);
                    break;

                case TypeOfData.String:
                    RunBenchmark(stringList, stringSearchPositive);
                    break;

                case TypeOfData.Record:
                    RunBenchmark(recordList, recordSearchPositive);
                    break;
            }
        }
    }
}
