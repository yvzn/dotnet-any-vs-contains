using BenchmarkDotNet.Running;

namespace AnyVsContainsBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarks>();
            BenchmarkRunner.Run<BenchmarkForLists>();
            BenchmarkRunner.Run<BenchmarksForCollections>();
        }
    }
}
