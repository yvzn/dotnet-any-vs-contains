# Any vs Contains Benchmark

What is the <q>better</q> solution to search for a specific `value` in a
given `source` collection 👀 ?

Alternatives:
- `source.Contains('value')` 
- `source.Any(item => item.Equals('value'))`

If `source` is a `List<T>` one can also:
- `source.Exists('value')` 

Here is my humble micro-benchmark for each solution — using [BenchmarkDotNet](https://benchmarkdotnet.org/)

*Disclaimer*: I am no .NET expert so any suggestion is warmly welcomed 👍
(please use github issues)

The algorithms are tested against:
- Different framework versions (.NET 6 preview, .NET 5 and .NET Core 3)
- Different types of collections (`Array`, `List` and `HashSet`)
- Different types of values (`string`, `int` and a simple POCO)
- Different sizes (100, 10_000, 1_000_000)

Results are visible in the `BenchmarkDotNet.Artifacts` folder.

## Run locally

Requirements:
- .NET >= 6.0

Make sure you always use `--configuration Release` otherwise the tooling
will not work.

Build in *Release* configuration
```bash
dotnet build --configuration Release
```

Run the unit tests
```bash
dotnet test --configuration Release
```

Run the benchmarks
```bash
dotnet run --configuration Release --project .\benchmark\AnyVsContainsBenchmark\ --framework net6.0
```

## Results

Results are visible in the `BenchmarkDotNet.Artifacts` folder.

Quick analysis (to be completed):
- `Contains` is arguably faster than `Any` for any collection type
- `HashSet` is the fastest collection for searching but has some caveats
  - more memory pressure
  - slower init
- `List.Exists` has the same functionality as `List.Any` but is (surprisingly) 2x faster

My conclusions:
- if you can afford the memory overhead, use `HashSet` and `HashSet.Contains`
- if you have specifically a `List<T>`, use `List<T>.Exists` (not available for other collections)
- otherwise prefer `Contains` over `Any`
