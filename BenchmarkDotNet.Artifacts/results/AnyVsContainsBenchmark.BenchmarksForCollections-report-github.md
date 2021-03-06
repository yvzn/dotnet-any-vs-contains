``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i5-4310U CPU 2.00GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.5.21302.13
  [Host]        : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT
  .NET 5.0      : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET 6.0      : .NET 6.0.0 (6.0.21.30105), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT


```
|            Method |           Job |       Runtime |    Type |       N |    Coll |            Mean |         Error |        StdDev |          Median |      Gen 0 |      Gen 1 |     Gen 2 |  Allocated |
|------------------ |-------------- |-------------- |-------- |-------- |-------- |----------------:|--------------:|--------------:|----------------:|-----------:|-----------:|----------:|-----------:|
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |   **Array** |        **13.01 μs** |      **0.256 μs** |      **0.563 μs** |        **12.92 μs** |     **1.6479** |          **-** |         **-** |       **3 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |     100 |   Array |        12.37 μs |      0.217 μs |      0.193 μs |        12.32 μs |     1.6479 |          - |         - |       3 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |   Array |        14.32 μs |      0.284 μs |      0.491 μs |        14.25 μs |     1.6937 |          - |         - |       3 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |    **List** |        **12.67 μs** |      **0.226 μs** |      **0.241 μs** |        **12.67 μs** |     **1.6632** |          **-** |         **-** |       **3 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |     100 |    List |        12.73 μs |      0.251 μs |      0.299 μs |        12.63 μs |     1.6632 |          - |         - |       3 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |    List |        13.73 μs |      0.076 μs |      0.071 μs |        13.73 μs |     1.7242 |          - |         - |       3 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** | **HashSet** |        **16.58 μs** |      **0.257 μs** |      **0.214 μs** |        **16.64 μs** |     **5.2490** |          **-** |         **-** |       **8 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |     100 | HashSet |        16.31 μs |      0.164 μs |      0.154 μs |        16.29 μs |     5.2185 |          - |         - |       8 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 | HashSet |        18.83 μs |      0.374 μs |      0.806 μs |        18.52 μs |     5.2795 |          - |         - |       8 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |   **Array** |     **2,119.35 μs** |     **34.885 μs** |     **64.661 μs** |     **2,096.82 μs** |   **113.2813** |    **23.4375** |         **-** |     **246 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |   Array |     2,027.65 μs |     13.555 μs |     12.680 μs |     2,022.61 μs |   113.2813 |    23.4375 |         - |     246 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |   Array |     2,361.64 μs |     19.951 μs |     16.660 μs |     2,357.84 μs |   113.2813 |    23.4375 |         - |     246 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |    **List** |     **2,137.14 μs** |     **15.897 μs** |     **14.870 μs** |     **2,133.23 μs** |   **125.0000** |    **23.4375** |         **-** |     **246 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |    List |     2,087.65 μs |      9.487 μs |      8.410 μs |     2,087.57 μs |   125.0000 |    23.4375 |         - |     246 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |    List |     2,425.61 μs |     33.283 μs |     31.133 μs |     2,422.04 μs |   125.0000 |    23.4375 |         - |     246 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** | **HashSet** |     **2,636.38 μs** |     **24.319 μs** |     **21.558 μs** |     **2,635.92 μs** |   **210.9375** |   **109.3750** |   **93.7500** |     **733 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |   10000 | HashSet |     2,618.38 μs |     14.257 μs |     13.336 μs |     2,619.73 μs |   207.0313 |   105.4688 |   93.7500 |     733 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 | HashSet |     3,010.67 μs |     60.071 μs |     69.178 μs |     3,011.87 μs |   199.2188 |    97.6563 |   93.7500 |     733 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |   **Array** |   **469,130.53 μs** | **26,522.763 μs** | **77,368.144 μs** |   **440,928.00 μs** |  **2000.0000** |  **2000.0000** | **2000.0000** |  **19,919 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |   Array |   369,666.14 μs |  6,833.211 μs |  6,391.790 μs |   367,602.80 μs |  2000.0000 |  2000.0000 | 2000.0000 |  19,919 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |   Array |   417,975.34 μs |  7,541.908 μs |  6,685.705 μs |   417,143.10 μs |  2000.0000 |  2000.0000 | 2000.0000 |  19,919 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |    **List** |   **395,520.27 μs** |  **7,839.797 μs** | **16,536.793 μs** |   **393,942.05 μs** |  **2000.0000** |  **2000.0000** | **2000.0000** |  **19,919 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |    List |   369,802.34 μs |  6,400.080 μs |  5,986.639 μs |   368,189.80 μs |  2000.0000 |  2000.0000 | 2000.0000 |  19,919 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |    List |   420,615.53 μs |  8,277.680 μs |  7,742.947 μs |   420,608.50 μs |  2000.0000 |  2000.0000 | 2000.0000 |  19,919 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** | **HashSet** |   **572,836.13 μs** |  **7,452.995 μs** |  **6,971.536 μs** |   **570,722.30 μs** |  **3000.0000** |  **3000.0000** | **3000.0000** |  **58,107 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 | HashSet |   548,020.54 μs | 10,773.526 μs |  9,550.450 μs |   544,927.35 μs |  3000.0000 |  3000.0000 | 3000.0000 |  58,106 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 | HashSet |   607,384.24 μs | 12,006.360 μs | 11,230.756 μs |   602,611.00 μs |  3000.0000 |  3000.0000 | 3000.0000 |  58,107 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |   **Array** |        **19.03 μs** |      **0.104 μs** |      **0.092 μs** |        **19.03 μs** |     **5.0659** |          **-** |         **-** |       **8 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |     100 |   Array |        19.06 μs |      0.125 μs |      0.117 μs |        19.09 μs |     5.0659 |          - |         - |       8 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |   Array |        21.52 μs |      0.126 μs |      0.105 μs |        21.56 μs |     5.1270 |          - |         - |       8 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |    **List** |        **19.61 μs** |      **0.165 μs** |      **0.147 μs** |        **19.60 μs** |     **5.0964** |          **-** |         **-** |       **8 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |     100 |    List |        19.24 μs |      0.106 μs |      0.094 μs |        19.24 μs |     5.0964 |          - |         - |       8 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |    List |        21.31 μs |      0.137 μs |      0.128 μs |        21.29 μs |     5.1270 |          - |         - |       8 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** | **HashSet** |        **24.72 μs** |      **0.287 μs** |      **0.254 μs** |        **24.76 μs** |     **9.2773** |          **-** |         **-** |      **14 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |     100 | HashSet |        24.65 μs |      0.167 μs |      0.156 μs |        24.66 μs |     9.2773 |          - |         - |      14 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |     100 | HashSet |        28.49 μs |      0.409 μs |      0.319 μs |        28.45 μs |     9.3384 |          - |         - |      14 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |   **Array** |     **3,224.95 μs** |     **19.228 μs** |     **17.045 μs** |     **3,226.60 μs** |   **125.0000** |    **78.1250** |   **39.0625** |     **803 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |   10000 |   Array |     3,349.91 μs |     32.513 μs |     30.413 μs |     3,351.55 μs |   136.7188 |    93.7500 |   39.0625 |     803 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |   Array |     3,853.87 μs |     14.933 μs |     13.968 μs |     3,854.57 μs |   125.0000 |    62.5000 |   39.0625 |     803 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |    **List** |     **3,233.47 μs** |     **28.767 μs** |     **26.909 μs** |     **3,228.69 μs** |   **125.0000** |    **78.1250** |   **39.0625** |     **803 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |   10000 |    List |     3,382.98 μs |     35.984 μs |     33.659 μs |     3,375.06 μs |   144.5313 |    97.6563 |   39.0625 |     803 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |    List |     3,878.26 μs |     28.304 μs |     26.476 μs |     3,876.18 μs |   125.0000 |    62.5000 |   39.0625 |     803 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** | **HashSet** |     **3,864.67 μs** |     **37.051 μs** |     **32.844 μs** |     **3,864.29 μs** |   **167.9688** |   **164.0625** |  **164.0625** |   **1,383 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |   10000 | HashSet |     3,809.71 μs |     25.822 μs |     24.154 μs |     3,812.74 μs |   167.9688 |   164.0625 |  164.0625 |   1,383 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 | HashSet |     4,365.18 μs |     48.061 μs |     42.605 μs |     4,375.33 μs |   171.8750 |   164.0625 |  164.0625 |   1,383 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |   **Array** |   **558,787.84 μs** |  **9,455.766 μs** |  **8,382.290 μs** |   **556,111.35 μs** |  **9000.0000** |  **4000.0000** | **3000.0000** |  **71,073 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |   Array |   550,693.59 μs |  6,854.473 μs |  6,411.679 μs |   549,855.60 μs |  9000.0000 |  4000.0000 | 3000.0000 |  71,071 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |   Array |   638,133.79 μs |  5,984.201 μs |  4,997.079 μs |   638,450.20 μs |  9000.0000 |  4000.0000 | 3000.0000 |  71,072 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |    **List** |   **563,670.21 μs** |  **8,299.932 μs** |  **7,763.762 μs** |   **564,618.30 μs** |  **9000.0000** |  **4000.0000** | **3000.0000** |  **71,070 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |    List |   556,254.07 μs |  9,900.090 μs |  9,260.550 μs |   556,656.70 μs |  9000.0000 |  4000.0000 | 3000.0000 |  71,071 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |    List |   634,472.67 μs |  9,987.890 μs |  9,342.679 μs |   636,418.30 μs |  9000.0000 |  4000.0000 | 3000.0000 |  71,070 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** | **HashSet** |   **894,189.03 μs** | **15,144.426 μs** | **14,166.105 μs** |   **889,774.40 μs** | **10000.0000** |  **5000.0000** | **4000.0000** | **115,883 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | HashSet |   883,572.60 μs |  9,983.661 μs |  9,338.723 μs |   884,766.60 μs | 10000.0000 |  5000.0000 | 4000.0000 | 115,884 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | HashSet |   953,207.15 μs |  8,415.959 μs |  7,027.707 μs |   953,408.20 μs | 10000.0000 |  5000.0000 | 4000.0000 | 115,881 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |   **Array** |        **35.09 μs** |      **0.386 μs** |      **0.361 μs** |        **35.11 μs** |    **13.1836** |          **-** |         **-** |      **20 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |     100 |   Array |        35.19 μs |      0.411 μs |      0.384 μs |        35.04 μs |    13.1836 |          - |         - |      20 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |   Array |        39.69 μs |      0.336 μs |      0.314 μs |        39.57 μs |    13.2446 |          - |         - |      20 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |    **List** |        **35.85 μs** |      **0.523 μs** |      **0.489 μs** |        **35.76 μs** |    **13.1836** |          **-** |         **-** |      **20 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |     100 |    List |        35.43 μs |      0.333 μs |      0.312 μs |        35.30 μs |    13.1836 |          - |         - |      20 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |    List |        39.29 μs |      0.264 μs |      0.247 μs |        39.35 μs |    13.2446 |          - |         - |      20 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** | **HashSet** |        **46.17 μs** |      **0.395 μs** |      **0.370 μs** |        **46.29 μs** |    **17.3950** |          **-** |         **-** |      **27 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |     100 | HashSet |        46.03 μs |      0.737 μs |      0.788 μs |        45.77 μs |    17.3340 |          - |         - |      27 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 | HashSet |        50.35 μs |      0.356 μs |      0.316 μs |        50.28 μs |    17.4561 |          - |         - |      27 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |   **Array** |     **6,383.52 μs** |    **126.874 μs** |    **146.108 μs** |     **6,387.60 μs** |   **351.5625** |   **179.6875** |   **70.3125** |   **2,053 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |   Array |     6,222.81 μs |    104.466 μs |     92.606 μs |     6,213.78 μs |   351.5625 |   179.6875 |   70.3125 |   2,053 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |   Array |     7,714.00 μs |    148.932 μs |    152.943 μs |     7,705.98 μs |   351.5625 |   179.6875 |   70.3125 |   2,053 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |    **List** |     **6,434.71 μs** |    **120.251 μs** |    **112.483 μs** |     **6,453.36 μs** |   **359.3750** |   **171.8750** |   **70.3125** |   **2,053 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |    List |     6,325.52 μs |    126.340 μs |    118.178 μs |     6,333.45 μs |   359.3750 |   171.8750 |   70.3125 |   2,053 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |    List |     7,856.12 μs |     83.863 μs |     65.474 μs |     7,858.33 μs |   359.3750 |   171.8750 |   70.3125 |   2,053 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** | **HashSet** |     **7,738.93 μs** |     **99.315 μs** |     **92.900 μs** |     **7,736.56 μs** |   **375.0000** |   **203.1250** |  **156.2500** |   **2,632 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |   10000 | HashSet |     7,802.91 μs |    112.395 μs |     99.636 μs |     7,783.27 μs |   375.0000 |   210.9375 |  164.0625 |   2,632 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 | HashSet |     9,013.04 μs |    151.451 μs |    141.668 μs |     9,004.76 μs |   375.0000 |   203.1250 |  156.2500 |   2,633 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |   **Array** |   **944,841.80 μs** |  **9,559.123 μs** |  **8,941.609 μs** |   **941,128.30 μs** | **29000.0000** | **11000.0000** | **3000.0000** | **196,060 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |   Array |   942,568.16 μs | 10,798.075 μs |  9,572.212 μs |   942,595.90 μs | 29000.0000 | 11000.0000 | 3000.0000 | 196,061 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |   Array | 1,065,483.96 μs | 14,548.401 μs | 13,608.583 μs | 1,062,353.60 μs | 29000.0000 | 11000.0000 | 3000.0000 | 196,061 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |    **List** |   **952,858.86 μs** | **12,566.888 μs** | **11,140.219 μs** |   **951,675.45 μs** | **29000.0000** | **11000.0000** | **3000.0000** | **196,061 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |    List |   944,387.51 μs | 11,429.170 μs | 10,690.853 μs |   945,153.70 μs | 29000.0000 | 11000.0000 | 3000.0000 | 196,061 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |    List | 1,065,181.36 μs | 13,220.531 μs | 12,366.492 μs | 1,063,298.50 μs | 29000.0000 | 11000.0000 | 3000.0000 | 196,061 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** | **HashSet** | **1,518,413.10 μs** | **13,004.384 μs** | **12,164.309 μs** | **1,519,921.10 μs** | **30000.0000** | **12000.0000** | **4000.0000** | **240,874 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 | HashSet | 1,530,199.48 μs | 27,317.820 μs | 25,553.106 μs | 1,523,923.10 μs | 30000.0000 | 12000.0000 | 4000.0000 | 240,874 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 | HashSet | 1,662,997.21 μs | 11,903.437 μs |  9,939.909 μs | 1,664,015.20 μs | 30000.0000 | 12000.0000 | 4000.0000 | 240,874 KB |
