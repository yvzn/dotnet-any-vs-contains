``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i5-4310U CPU 2.00GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.5.21302.13
  [Host]        : .NET 6.0.0 (6.0.21.30105), X64 RyuJIT
  .NET 5.0      : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET 6.0      : .NET 6.0.0 (6.0.21.30105), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT


```
|            Method |           Job |       Runtime |    Type |       N |    Coll |            Mean |         Error |        StdDev |      Gen 0 |      Gen 1 |     Gen 2 |  Allocated |
|------------------ |-------------- |-------------- |-------- |-------- |-------- |----------------:|--------------:|--------------:|-----------:|-----------:|----------:|-----------:|
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |   **Array** |        **12.16 μs** |      **0.059 μs** |      **0.050 μs** |     **1.6479** |          **-** |         **-** |       **3 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |     100 |   Array |        12.03 μs |      0.092 μs |      0.086 μs |     1.6479 |          - |         - |       3 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |   Array |        13.48 μs |      0.078 μs |      0.073 μs |     1.6937 |          - |         - |       3 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |    **List** |        **12.32 μs** |      **0.080 μs** |      **0.075 μs** |     **1.6632** |          **-** |         **-** |       **3 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |     100 |    List |        12.18 μs |      0.124 μs |      0.110 μs |     1.6632 |          - |         - |       3 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |    List |        13.40 μs |      0.086 μs |      0.076 μs |     1.7242 |          - |         - |       3 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** | **HashSet** |        **16.32 μs** |      **0.069 μs** |      **0.061 μs** |     **5.2490** |          **-** |         **-** |       **8 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |     100 | HashSet |        16.17 μs |      0.152 μs |      0.142 μs |     5.2185 |          - |         - |       8 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 | HashSet |        18.61 μs |      0.259 μs |      0.202 μs |     5.2795 |          - |         - |       8 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |   **Array** |     **2,126.00 μs** |     **13.256 μs** |     **12.400 μs** |   **113.2813** |    **23.4375** |         **-** |     **246 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |   Array |     2,017.75 μs |     12.977 μs |     12.139 μs |   113.2813 |    23.4375 |         - |     246 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |   Array |     2,308.78 μs |     15.805 μs |     14.784 μs |   113.2813 |    23.4375 |         - |     246 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |    **List** |     **2,100.24 μs** |     **23.401 μs** |     **19.541 μs** |   **125.0000** |    **23.4375** |         **-** |     **246 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |    List |     2,034.29 μs |     12.548 μs |     11.737 μs |   125.0000 |    23.4375 |         - |     246 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |    List |     2,322.62 μs |     16.004 μs |     14.970 μs |   125.0000 |    23.4375 |         - |     246 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** | **HashSet** |     **2,682.96 μs** |     **51.167 μs** |     **56.872 μs** |   **210.9375** |   **109.3750** |   **93.7500** |     **733 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer |   10000 | HashSet |     2,553.39 μs |     17.237 μs |     15.280 μs |   207.0313 |   105.4688 |   93.7500 |     733 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 | HashSet |     2,970.67 μs |     24.948 μs |     20.833 μs |   199.2188 |    97.6563 |   93.7500 |     733 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |   **Array** |   **375,200.24 μs** |  **5,130.255 μs** |  **4,547.838 μs** |  **2000.0000** |  **2000.0000** | **2000.0000** |  **19,921 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |   Array |   367,080.79 μs |  7,271.991 μs |  6,446.431 μs |  2000.0000 |  2000.0000 | 2000.0000 |  19,920 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |   Array |   414,670.76 μs |  8,200.910 μs |  8,774.882 μs |  2000.0000 |  2000.0000 | 2000.0000 |  19,921 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |    **List** |   **379,458.67 μs** |  **6,575.673 μs** |  **6,150.889 μs** |  **2000.0000** |  **2000.0000** | **2000.0000** |  **19,920 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |    List |   368,506.42 μs |  6,889.042 μs |  6,444.014 μs |  2000.0000 |  2000.0000 | 2000.0000 |  19,922 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |    List |   423,740.15 μs |  6,351.732 μs |  5,941.414 μs |  2000.0000 |  2000.0000 | 2000.0000 |  19,919 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** | **HashSet** |   **559,910.12 μs** |  **8,424.621 μs** |  **7,880.396 μs** |  **3000.0000** |  **3000.0000** | **3000.0000** |  **58,107 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 | HashSet |   543,614.51 μs |  7,165.771 μs |  5,983.744 μs |  3000.0000 |  3000.0000 | 3000.0000 |  58,108 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 | HashSet |   590,567.90 μs |  9,203.697 μs |  8,158.838 μs |  2000.0000 |  2000.0000 | 2000.0000 |  58,107 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |   **Array** |        **19.20 μs** |      **0.134 μs** |      **0.125 μs** |     **5.0659** |          **-** |         **-** |       **8 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |     100 |   Array |        18.65 μs |      0.176 μs |      0.164 μs |     5.0659 |          - |         - |       8 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |   Array |        20.96 μs |      0.158 μs |      0.148 μs |     5.1270 |          - |         - |       8 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |    **List** |        **19.08 μs** |      **0.109 μs** |      **0.102 μs** |     **5.0964** |          **-** |         **-** |       **8 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |     100 |    List |        18.85 μs |      0.136 μs |      0.128 μs |     5.0964 |          - |         - |       8 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |    List |        21.26 μs |      0.086 μs |      0.067 μs |     5.1270 |          - |         - |       8 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** | **HashSet** |        **24.19 μs** |      **0.177 μs** |      **0.165 μs** |     **9.2773** |          **-** |         **-** |      **14 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |     100 | HashSet |        23.94 μs |      0.347 μs |      0.290 μs |     9.2773 |          - |         - |      14 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |     100 | HashSet |        27.94 μs |      0.228 μs |      0.202 μs |     9.3384 |          - |         - |      14 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |   **Array** |     **3,204.95 μs** |     **23.359 μs** |     **20.707 μs** |   **125.0000** |    **62.5000** |   **39.0625** |     **803 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |   10000 |   Array |     3,296.18 μs |     29.942 μs |     26.543 μs |   140.6250 |    97.6563 |   39.0625 |     803 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |   Array |     3,805.00 μs |     32.498 μs |     30.398 μs |   125.0000 |    62.5000 |   39.0625 |     803 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |    **List** |     **3,203.95 μs** |     **21.562 μs** |     **20.169 μs** |   **125.0000** |    **78.1250** |   **39.0625** |     **803 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |   10000 |    List |     3,346.52 μs |     36.160 μs |     33.825 μs |   144.5313 |    97.6563 |   39.0625 |     803 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |    List |     3,798.77 μs |     39.184 μs |     36.653 μs |   125.0000 |    62.5000 |   39.0625 |     803 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** | **HashSet** |     **3,777.14 μs** |     **38.616 μs** |     **42.922 μs** |   **167.9688** |   **164.0625** |  **164.0625** |   **1,383 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String |   10000 | HashSet |     3,708.26 μs |     22.015 μs |     20.593 μs |   167.9688 |   164.0625 |  164.0625 |   1,383 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 | HashSet |     4,328.44 μs |     31.931 μs |     29.868 μs |   171.8750 |   164.0625 |  164.0625 |   1,383 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |   **Array** |   **552,734.17 μs** | **10,351.471 μs** | **11,075.958 μs** |  **9000.0000** |  **4000.0000** | **3000.0000** |  **71,078 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |   Array |   543,646.01 μs |  8,161.240 μs |  7,634.028 μs |  9000.0000 |  4000.0000 | 3000.0000 |  71,069 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |   Array |   617,503.34 μs | 12,155.244 μs | 11,370.023 μs |  9000.0000 |  4000.0000 | 3000.0000 |  71,068 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |    **List** |   **559,831.88 μs** |  **7,388.020 μs** |  **6,910.758 μs** |  **9000.0000** |  **4000.0000** | **3000.0000** |  **71,070 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |    List |   557,816.14 μs |  8,909.390 μs |  8,333.849 μs |  9000.0000 |  4000.0000 | 3000.0000 |  71,071 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |    List |   639,455.55 μs | 11,666.915 μs |  9,742.402 μs |  9000.0000 |  4000.0000 | 3000.0000 |  71,068 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** | **HashSet** |   **866,222.81 μs** | **12,633.484 μs** | **11,817.369 μs** | **10000.0000** |  **5000.0000** | **4000.0000** | **115,883 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | HashSet |   866,852.42 μs |  7,703.610 μs |  6,432.863 μs | 10000.0000 |  5000.0000 | 4000.0000 | 115,884 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | HashSet |   930,124.91 μs | 16,189.690 μs | 15,143.846 μs | 10000.0000 |  5000.0000 | 4000.0000 | 115,884 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |   **Array** |        **34.68 μs** |      **0.196 μs** |      **0.174 μs** |    **13.1836** |          **-** |         **-** |      **20 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |     100 |   Array |        34.66 μs |      0.173 μs |      0.162 μs |    13.1836 |          - |         - |      20 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |   Array |        38.97 μs |      0.326 μs |      0.305 μs |    13.2446 |          - |         - |      20 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |    **List** |        **34.41 μs** |      **0.211 μs** |      **0.198 μs** |    **13.1836** |          **-** |         **-** |      **20 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |     100 |    List |        34.58 μs |      0.229 μs |      0.214 μs |    13.1836 |          - |         - |      20 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |    List |        39.30 μs |      0.203 μs |      0.180 μs |    13.2446 |          - |         - |      20 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** | **HashSet** |        **45.44 μs** |      **0.306 μs** |      **0.286 μs** |    **17.3950** |          **-** |         **-** |      **27 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |     100 | HashSet |        45.05 μs |      0.197 μs |      0.154 μs |    17.3340 |          - |         - |      27 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 | HashSet |        50.46 μs |      0.295 μs |      0.276 μs |    17.4561 |          - |         - |      27 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |   **Array** |     **6,081.33 μs** |     **22.654 μs** |     **20.082 μs** |   **351.5625** |   **179.6875** |   **70.3125** |   **2,053 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |   Array |     6,165.73 μs |     69.282 μs |     64.806 μs |   359.3750 |   171.8750 |   70.3125 |   2,053 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |   Array |     7,549.14 μs |    140.810 μs |    150.665 μs |   343.7500 |   156.2500 |   62.5000 |   2,053 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |    **List** |     **6,320.12 μs** |    **118.481 μs** |    **105.031 μs** |   **359.3750** |   **171.8750** |   **70.3125** |   **2,053 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |    List |     6,295.94 μs |     68.398 μs |     53.401 μs |   359.3750 |   171.8750 |   70.3125 |   2,053 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |    List |     7,887.32 μs |    147.174 μs |    300.638 μs |   351.5625 |   179.6875 |   70.3125 |   2,053 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** | **HashSet** |     **7,650.47 μs** |     **58.296 μs** |     **54.530 μs** |   **375.0000** |   **210.9375** |  **164.0625** |   **2,632 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record |   10000 | HashSet |     7,846.07 μs |     65.373 μs |     54.589 μs |   375.0000 |   210.9375 |  164.0625 |   2,632 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 | HashSet |     8,987.77 μs |    166.996 μs |    148.037 μs |   375.0000 |   203.1250 |  156.2500 |   2,633 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |   **Array** |   **947,750.14 μs** |  **8,669.742 μs** |  **8,109.682 μs** | **29000.0000** | **11000.0000** | **3000.0000** | **196,060 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |   Array |   951,599.79 μs | 12,449.718 μs | 11,645.474 μs | 29000.0000 | 11000.0000 | 3000.0000 | 196,061 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |   Array | 1,048,091.82 μs | 16,334.407 μs | 14,480.027 μs | 29000.0000 | 11000.0000 | 3000.0000 | 196,061 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |    **List** |   **951,128.75 μs** | **10,831.186 μs** | **10,131.498 μs** | **29000.0000** | **11000.0000** | **3000.0000** | **196,061 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |    List |   947,586.95 μs | 16,204.912 μs | 15,158.084 μs | 29000.0000 | 11000.0000 | 3000.0000 | 196,063 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |    List | 1,057,088.15 μs | 11,240.182 μs | 10,514.073 μs | 29000.0000 | 11000.0000 | 3000.0000 | 196,069 KB |
| **CreateCollections** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** | **HashSet** | **1,523,554.59 μs** | **13,525.763 μs** | **12,652.008 μs** | **30000.0000** | **12000.0000** | **4000.0000** | **240,874 KB** |
| CreateCollections |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 | HashSet | 1,505,358.71 μs | 14,851.031 μs | 13,891.663 μs | 30000.0000 | 12000.0000 | 4000.0000 | 240,874 KB |
| CreateCollections | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 | HashSet | 1,651,014.19 μs | 22,922.908 μs | 21,442.102 μs | 30000.0000 | 12000.0000 | 4000.0000 | 240,875 KB |
