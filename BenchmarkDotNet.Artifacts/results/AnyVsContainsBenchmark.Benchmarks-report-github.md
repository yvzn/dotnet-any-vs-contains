``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i5-4310U CPU 2.00GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.5.21302.13
  [Host]        : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT
  .NET 5.0      : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET 6.0      : .NET 6.0.0 (6.0.21.30105), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT


```
|        Method |           Job |       Runtime |    Type |       N |    Coll |     Algo |             Mean |          Error |           StdDev |           Median |
|-------------- |-------------- |-------------- |-------- |-------- |-------- |--------- |-----------------:|---------------:|-----------------:|-----------------:|
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |   **Array** |      **Any** |        **601.48 ns** |       **4.007 ns** |         **3.748 ns** |        **601.15 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |   Array |      Any |        557.84 ns |       6.121 ns |         5.725 ns |        557.60 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |   Array |      Any |        587.30 ns |       4.685 ns |         4.153 ns |        586.46 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |   **Array** | **Contains** |         **43.62 ns** |       **0.214 ns** |         **0.179 ns** |         **43.60 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |   Array | Contains |         43.77 ns |       0.356 ns |         0.316 ns |         43.62 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |   Array | Contains |         50.75 ns |       0.415 ns |         0.388 ns |         50.77 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |    **List** |      **Any** |        **700.52 ns** |       **5.866 ns** |         **5.487 ns** |        **702.49 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |    List |      Any |        723.71 ns |       5.347 ns |         4.740 ns |        725.41 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |    List |      Any |        697.23 ns |       5.177 ns |         4.323 ns |        697.29 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |    **List** | **Contains** |         **39.18 ns** |       **0.730 ns** |         **0.570 ns** |         **39.06 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |    List | Contains |         39.82 ns |       0.272 ns |         0.254 ns |         39.76 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |    List | Contains |         37.65 ns |       0.217 ns |         0.192 ns |         37.69 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** | **HashSet** |      **Any** |        **721.56 ns** |       **7.066 ns** |         **6.609 ns** |        **722.16 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 | HashSet |      Any |        684.25 ns |       5.170 ns |         4.836 ns |        684.51 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 | HashSet |      Any |        759.70 ns |       9.067 ns |         7.079 ns |        759.10 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** | **HashSet** | **Contains** |         **22.02 ns** |       **0.213 ns** |         **0.189 ns** |         **22.09 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 | HashSet | Contains |         26.62 ns |       0.190 ns |         0.159 ns |         26.66 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 | HashSet | Contains |         27.92 ns |       0.244 ns |         0.216 ns |         27.86 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |   **Array** |      **Any** |      **6,501.87 ns** |      **56.002 ns** |        **49.644 ns** |      **6,502.57 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |   Array |      Any |      5,982.94 ns |      32.024 ns |        28.388 ns |      5,988.40 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |   Array |      Any |      6,120.91 ns |      50.140 ns |        41.869 ns |      6,120.17 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |   **Array** | **Contains** |        **198.42 ns** |       **1.210 ns** |         **1.132 ns** |        **198.76 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |   Array | Contains |        171.36 ns |       1.860 ns |         1.740 ns |        170.99 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |   Array | Contains |        217.31 ns |       1.179 ns |         1.103 ns |        217.77 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |    **List** |      **Any** |      **7,332.50 ns** |      **36.616 ns** |        **34.250 ns** |      **7,346.18 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |    List |      Any |      7,922.84 ns |      52.462 ns |        49.073 ns |      7,939.49 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |    List |      Any |      7,417.57 ns |      46.154 ns |        43.172 ns |      7,408.62 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |    **List** | **Contains** |        **191.98 ns** |       **1.223 ns** |         **1.144 ns** |        **191.77 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |    List | Contains |        167.90 ns |       1.097 ns |         1.026 ns |        168.33 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |    List | Contains |        196.06 ns |       1.166 ns |         1.091 ns |        196.20 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** | **HashSet** |      **Any** |      **7,583.46 ns** |      **58.087 ns** |        **54.335 ns** |      **7,596.76 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 | HashSet |      Any |      7,712.89 ns |      56.157 ns |        52.529 ns |      7,715.55 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 | HashSet |      Any |      8,369.81 ns |      49.264 ns |        43.671 ns |      8,371.50 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** | **HashSet** | **Contains** |         **22.92 ns** |       **0.176 ns** |         **0.164 ns** |         **22.98 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 | HashSet | Contains |         26.60 ns |       0.210 ns |         0.186 ns |         26.69 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 | HashSet | Contains |         27.76 ns |       0.234 ns |         0.219 ns |         27.78 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |   **Array** |      **Any** |  **7,847,884.38 ns** |  **23,677.218 ns** |    **22,147.685 ns** |  **7,854,335.94 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |   Array |      Any |  8,100,143.85 ns |  42,761.717 ns |    39,999.337 ns |  8,098,654.69 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |   Array |      Any |  8,009,301.15 ns |  57,043.482 ns |    53,358.509 ns |  8,017,818.75 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |   **Array** | **Contains** |    **238,944.23 ns** |   **4,068.711 ns** |     **3,805.875 ns** |    **238,096.88 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |   Array | Contains |    211,709.16 ns |   2,077.341 ns |     1,943.146 ns |    210,931.73 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |   Array | Contains |    241,406.57 ns |   4,308.626 ns |     4,030.291 ns |    240,775.17 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |    **List** |      **Any** | **10,105,656.09 ns** |  **62,562.096 ns** |    **58,520.624 ns** | **10,107,771.09 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |    List |      Any | 10,141,501.45 ns |  53,663.800 ns |    47,571.560 ns | 10,140,698.44 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |    List |      Any |  9,999,582.81 ns |  78,908.998 ns |    73,811.525 ns |  9,984,618.75 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |    **List** | **Contains** |    **233,457.93 ns** |   **4,458.850 ns** |     **4,379.187 ns** |    **232,840.78 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |    List | Contains |    200,156.80 ns |   3,917.623 ns |     4,023.110 ns |    199,211.38 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |    List | Contains |    235,131.33 ns |   1,458.395 ns |     1,364.184 ns |    235,365.87 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** | **HashSet** |      **Any** | **10,551,041.63 ns** |  **31,466.015 ns** |    **27,893.803 ns** | **10,561,433.59 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 | HashSet |      Any | 10,225,487.24 ns |  80,099.259 ns |    74,924.896 ns | 10,233,024.22 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 | HashSet |      Any | 10,528,275.57 ns |  59,874.280 ns |    56,006.439 ns | 10,534,425.78 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** | **HashSet** | **Contains** |         **23.36 ns** |       **0.152 ns** |         **0.142 ns** |         **23.34 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 | HashSet | Contains |         27.03 ns |       0.178 ns |         0.167 ns |         27.02 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 | HashSet | Contains |         28.48 ns |       0.238 ns |         0.211 ns |         28.51 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |   **Array** |      **Any** |        **601.76 ns** |       **4.910 ns** |         **4.352 ns** |        **602.21 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 |   Array |      Any |        533.57 ns |       3.998 ns |         3.740 ns |        533.39 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |   Array |      Any |        553.83 ns |       3.925 ns |         3.278 ns |        554.87 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |   **Array** | **Contains** |        **186.70 ns** |       **1.227 ns** |         **1.147 ns** |        **187.08 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 |   Array | Contains |        187.28 ns |       1.019 ns |         0.903 ns |        187.51 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |   Array | Contains |        225.81 ns |       1.888 ns |         1.577 ns |        225.71 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |    **List** |      **Any** |        **768.72 ns** |       **5.817 ns** |         **5.441 ns** |        **769.42 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 |    List |      Any |        811.96 ns |       4.576 ns |         4.057 ns |        813.24 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |    List |      Any |        809.58 ns |       3.617 ns |         3.384 ns |        810.79 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |    **List** | **Contains** |        **237.04 ns** |       **1.337 ns** |         **1.117 ns** |        **237.43 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 |    List | Contains |        223.56 ns |       1.200 ns |         1.123 ns |        223.84 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |    List | Contains |        251.09 ns |       1.858 ns |         1.738 ns |        251.31 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** | **HashSet** |      **Any** |        **821.76 ns** |       **3.881 ns** |         **3.630 ns** |        **821.78 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 | HashSet |      Any |        794.32 ns |       4.781 ns |         4.238 ns |        793.77 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 | HashSet |      Any |        853.72 ns |       5.184 ns |         4.849 ns |        854.65 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** | **HashSet** | **Contains** |         **37.20 ns** |       **0.235 ns** |         **0.196 ns** |         **37.27 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 | HashSet | Contains |         39.72 ns |       0.291 ns |         0.272 ns |         39.81 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 | HashSet | Contains |         56.28 ns |       0.350 ns |         0.327 ns |         56.33 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |   **Array** |      **Any** |      **6,401.46 ns** |      **31.566 ns** |        **29.527 ns** |      **6,403.35 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |   Array |      Any |      5,831.45 ns |      35.359 ns |        31.345 ns |      5,829.88 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |   Array |      Any |      6,689.51 ns |      36.777 ns |        34.401 ns |      6,674.51 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |   **Array** | **Contains** |      **1,955.97 ns** |      **15.048 ns** |        **12.566 ns** |      **1,961.27 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |   Array | Contains |      2,184.46 ns |      11.854 ns |        11.088 ns |      2,185.04 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |   Array | Contains |      1,966.23 ns |       7.487 ns |         7.004 ns |      1,963.39 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |    **List** |      **Any** |      **8,608.14 ns** |      **71.890 ns** |        **67.246 ns** |      **8,604.15 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |    List |      Any |      9,175.12 ns |      41.581 ns |        38.895 ns |      9,177.84 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |    List |      Any |      8,543.45 ns |      76.493 ns |        71.552 ns |      8,564.42 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |    **List** | **Contains** |      **2,694.29 ns** |      **19.565 ns** |        **18.301 ns** |      **2,700.02 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |    List | Contains |      2,348.26 ns |      10.569 ns |         9.886 ns |      2,349.10 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |    List | Contains |      2,541.69 ns |      11.217 ns |         9.944 ns |      2,544.56 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** | **HashSet** |      **Any** |      **9,204.35 ns** |      **29.319 ns** |        **25.991 ns** |      **9,210.78 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 | HashSet |      Any |      8,973.74 ns |      68.977 ns |        61.146 ns |      8,956.62 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 | HashSet |      Any |      9,199.42 ns |      48.622 ns |        45.481 ns |      9,214.25 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** | **HashSet** | **Contains** |         **38.36 ns** |       **0.254 ns** |         **0.238 ns** |         **38.41 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 | HashSet | Contains |         40.68 ns |       0.398 ns |         0.372 ns |         40.84 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 | HashSet | Contains |         56.29 ns |       0.580 ns |         0.543 ns |         56.35 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |   **Array** |      **Any** | **29,265,277.50 ns** | **583,085.795 ns** |   **545,418.814 ns** | **29,281,203.12 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |   Array |      Any | 27,721,817.58 ns | 177,030.852 ns |   147,828.779 ns | 27,702,757.14 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |   Array |      Any | 28,781,165.62 ns | 303,062.571 ns |   268,657.075 ns | 28,816,007.81 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |   **Array** | **Contains** | **17,455,052.50 ns** | **295,150.921 ns** |   **276,084.354 ns** | **17,625,621.88 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |   Array | Contains | 16,880,766.59 ns | 121,199.077 ns |   101,206.718 ns | 16,861,000.00 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |   Array | Contains | 17,094,032.60 ns |  80,296.784 ns |    75,109.661 ns | 17,109,901.56 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |    **List** |      **Any** | **43,906,428.76 ns** | **871,530.116 ns** | **1,330,918.535 ns** | **43,652,316.67 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |    List |      Any | 42,764,156.66 ns | 841,982.562 ns | 1,518,268.239 ns | 42,655,553.85 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |    List |      Any | 48,763,026.67 ns | 961,523.602 ns | 1,347,921.802 ns | 48,345,040.00 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |    **List** | **Contains** | **19,865,294.47 ns** | **132,489.065 ns** |   **110,634.370 ns** | **19,821,881.25 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |    List | Contains | 19,993,454.79 ns | 109,955.313 ns |   102,852.268 ns | 19,958,981.25 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |    List | Contains | 18,443,442.19 ns | 279,393.315 ns |   261,344.680 ns | 18,524,226.56 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** | **HashSet** |      **Any** | **41,077,658.24 ns** | **234,313.966 ns** |   **207,713.228 ns** | **41,105,430.77 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | HashSet |      Any | 42,078,470.31 ns | 823,929.420 ns |   809,208.860 ns | 41,671,800.00 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | HashSet |      Any | 44,164,961.36 ns | 863,775.181 ns | 1,370,038.972 ns | 43,896,850.00 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** | **HashSet** | **Contains** |         **39.76 ns** |       **0.313 ns** |         **0.277 ns** |         **39.79 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | HashSet | Contains |         39.34 ns |       0.344 ns |         0.322 ns |         39.45 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | HashSet | Contains |         56.89 ns |       0.367 ns |         0.343 ns |         56.75 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |   **Array** |      **Any** |      **1,652.08 ns** |      **10.651 ns** |         **9.963 ns** |      **1,653.19 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |   Array |      Any |      1,602.05 ns |      10.844 ns |        10.143 ns |      1,606.55 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |   Array |      Any |      1,634.56 ns |      11.500 ns |        10.757 ns |      1,633.42 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |   **Array** | **Contains** |        **805.25 ns** |       **6.823 ns** |         **6.382 ns** |        **804.22 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |   Array | Contains |        828.99 ns |       4.307 ns |         4.029 ns |        830.26 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |   Array | Contains |        835.05 ns |       4.629 ns |         3.866 ns |        836.56 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |    **List** |      **Any** |      **2,164.75 ns** |      **13.420 ns** |        **11.896 ns** |      **2,164.85 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |    List |      Any |      2,189.37 ns |      19.057 ns |        17.826 ns |      2,186.92 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |    List |      Any |      2,112.32 ns |      14.141 ns |        12.536 ns |      2,113.82 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |    **List** | **Contains** |        **719.25 ns** |       **4.437 ns** |         **4.150 ns** |        **719.33 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |    List | Contains |        720.46 ns |       4.873 ns |         4.558 ns |        722.01 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |    List | Contains |        713.70 ns |       5.048 ns |         4.722 ns |        714.85 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** | **HashSet** |      **Any** |      **2,127.54 ns** |      **14.321 ns** |        **13.396 ns** |      **2,132.21 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 | HashSet |      Any |      2,237.10 ns |      13.292 ns |        11.783 ns |      2,238.57 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 | HashSet |      Any |      2,282.71 ns |      12.446 ns |        11.642 ns |      2,282.81 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** | **HashSet** | **Contains** |         **80.04 ns** |       **0.595 ns** |         **0.557 ns** |         **80.21 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 | HashSet | Contains |         79.79 ns |       0.491 ns |         0.460 ns |         79.79 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 | HashSet | Contains |         90.97 ns |       0.669 ns |         0.626 ns |         90.97 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |   **Array** |      **Any** |    **121,437.57 ns** |   **1,705.392 ns** |     **1,595.225 ns** |    **121,046.66 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |   Array |      Any |    118,755.76 ns |   1,297.243 ns |     1,213.442 ns |    118,641.39 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |   Array |      Any |    114,631.39 ns |   1,410.293 ns |     1,319.189 ns |    114,226.18 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |   **Array** | **Contains** |     **73,888.86 ns** |     **655.187 ns** |       **612.863 ns** |     **73,969.13 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |   Array | Contains |     72,152.54 ns |     513.134 ns |       454.880 ns |     72,182.54 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |   Array | Contains |     68,040.52 ns |     652.131 ns |       610.004 ns |     68,047.23 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |    **List** |      **Any** |    **155,056.77 ns** |   **2,259.969 ns** |     **2,113.977 ns** |    **155,409.11 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |    List |      Any |    148,417.04 ns |   1,276.112 ns |     1,193.676 ns |    148,249.66 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |    List |      Any |    147,138.10 ns |   1,181.857 ns |     1,105.509 ns |    146,804.54 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |    **List** | **Contains** |     **69,756.00 ns** |     **287.637 ns** |       **254.983 ns** |     **69,747.88 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |    List | Contains |     70,281.49 ns |     617.573 ns |       577.678 ns |     70,267.77 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |    List | Contains |     67,105.00 ns |     281.982 ns |       249.970 ns |     67,108.85 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** | **HashSet** |      **Any** |    **147,622.91 ns** |   **1,628.065 ns** |     **1,598.978 ns** |    **147,356.70 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 | HashSet |      Any |    147,986.67 ns |   2,028.492 ns |     1,897.453 ns |    148,820.85 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 | HashSet |      Any |    149,197.91 ns |   1,333.611 ns |     1,247.461 ns |    149,570.91 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** | **HashSet** | **Contains** |         **82.17 ns** |       **0.487 ns** |         **0.455 ns** |         **82.41 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 | HashSet | Contains |         81.50 ns |       0.594 ns |         0.555 ns |         81.61 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 | HashSet | Contains |         93.20 ns |       1.077 ns |         1.008 ns |         93.05 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |   **Array** |      **Any** |  **4,038,975.64 ns** |  **80,032.381 ns** |    **98,286.951 ns** |  **4,063,823.44 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |   Array |      Any |  3,854,589.67 ns |  76,107.565 ns |    96,251.701 ns |  3,838,263.67 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |   Array |      Any |  3,645,761.36 ns |  14,326.054 ns |    11,962.904 ns |  3,646,630.08 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |   **Array** | **Contains** |  **2,489,060.17 ns** |  **11,731.757 ns** |    **10,973.893 ns** |  **2,492,790.82 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |   Array | Contains |  2,639,373.95 ns |  52,049.801 ns |   112,042.687 ns |  2,607,250.00 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |   Array | Contains |  2,163,910.45 ns |  41,763.050 ns |    58,545.964 ns |  2,169,275.59 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |    **List** |      **Any** |  **4,165,591.06 ns** |  **81,872.155 ns** |   **129,857.914 ns** |  **4,132,466.80 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |    List |      Any |  4,186,278.93 ns |  83,674.343 ns |   130,270.871 ns |  4,248,738.28 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |    List |      Any |  4,795,879.82 ns | 148,839.008 ns |   436,519.046 ns |  4,783,531.64 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |    **List** | **Contains** |  **4,045,262.24 ns** | **267,311.809 ns** |   **788,174.901 ns** |  **3,847,690.23 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |    List | Contains |  3,590,732.28 ns |  71,737.307 ns |   182,594.351 ns |  3,548,601.17 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |    List | Contains |  2,485,186.61 ns |  78,113.530 ns |   230,319.504 ns |  2,450,702.54 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** | **HashSet** |      **Any** |  **6,837,418.72 ns** | **719,314.852 ns** | **2,120,916.069 ns** |  **5,897,563.67 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 | HashSet |      Any |  4,886,452.47 ns | 136,427.397 ns |   400,117.940 ns |  4,726,202.73 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 | HashSet |      Any |  4,876,016.09 ns | 131,620.122 ns |   386,019.035 ns |  4,834,651.56 ns |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** | **HashSet** | **Contains** |         **89.58 ns** |       **2.751 ns** |         **7.849 ns** |         **89.12 ns** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 | HashSet | Contains |         82.22 ns |       0.609 ns |         0.539 ns |         82.44 ns |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 | HashSet | Contains |         88.58 ns |       0.606 ns |         0.567 ns |         88.89 ns |
