``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i5-4310U CPU 2.00GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.5.21302.13
  [Host]        : .NET 6.0.0 (6.0.21.30105), X64 RyuJIT
  .NET 5.0      : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET 6.0      : .NET 6.0.0 (6.0.21.30105), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT


```
|        Method |           Job |       Runtime |    Type |       N |    Coll |     Algo |             Mean |            Error |           StdDev |           Median |      Gen 0 | Gen 1 | Gen 2 |    Allocated |
|-------------- |-------------- |-------------- |-------- |-------- |-------- |--------- |-----------------:|-----------------:|-----------------:|-----------------:|-----------:|------:|------:|-------------:|
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |   **Array** |      **Any** |        **660.82 ns** |        **13.230 ns** |        **33.435 ns** |        **660.64 ns** |     **0.7496** |     **-** |     **-** |      **1,176 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |   Array |      Any |        646.25 ns |        14.293 ns |        41.010 ns |        640.82 ns |     0.7496 |     - |     - |      1,176 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |   Array |      Any |        743.03 ns |        45.867 ns |       135.241 ns |        680.06 ns |     0.7496 |     - |     - |      1,176 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |   **Array** | **Contains** |         **46.61 ns** |         **0.602 ns** |         **0.563 ns** |         **46.47 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |   Array | Contains |         46.28 ns |         0.949 ns |         1.759 ns |         45.90 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |   Array | Contains |         54.70 ns |         1.095 ns |         1.075 ns |         54.52 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |    **List** |      **Any** |        **758.40 ns** |        **14.776 ns** |        **15.811 ns** |        **753.64 ns** |     **0.7544** |     **-** |     **-** |      **1,184 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |    List |      Any |        730.55 ns |        14.342 ns |        21.902 ns |        726.26 ns |     0.7544 |     - |     - |      1,184 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |    List |      Any |        758.86 ns |        14.672 ns |        30.300 ns |        753.03 ns |     0.7544 |     - |     - |      1,184 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |    **List** | **Contains** |         **38.01 ns** |         **0.771 ns** |         **1.177 ns** |         **37.62 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |    List | Contains |         39.46 ns |         0.329 ns |         0.292 ns |         39.40 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |    List | Contains |         36.54 ns |         0.358 ns |         0.317 ns |         36.42 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** | **HashSet** |      **Any** |        **738.94 ns** |         **3.455 ns** |         **2.885 ns** |        **738.83 ns** |     **0.7544** |     **-** |     **-** |      **1,184 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 | HashSet |      Any |        722.50 ns |         7.515 ns |         6.662 ns |        721.95 ns |     0.7544 |     - |     - |      1,184 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 | HashSet |      Any |        711.41 ns |         5.109 ns |         4.529 ns |        711.58 ns |     0.7544 |     - |     - |      1,184 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** | **HashSet** | **Contains** |         **22.21 ns** |         **0.135 ns** |         **0.126 ns** |         **22.24 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |     100 | HashSet | Contains |         26.28 ns |         0.127 ns |         0.119 ns |         26.31 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 | HashSet | Contains |         29.34 ns |         0.181 ns |         0.169 ns |         29.36 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |   **Array** |      **Any** |      **6,642.17 ns** |       **124.454 ns** |       **178.488 ns** |      **6,560.89 ns** |     **8.1406** |     **-** |     **-** |     **12,768 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |   Array |      Any |      6,424.98 ns |        83.853 ns |        65.467 ns |      6,420.27 ns |     8.1406 |     - |     - |     12,768 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |   Array |      Any |      6,327.53 ns |        66.961 ns |        55.916 ns |      6,344.61 ns |     8.1406 |     - |     - |     12,768 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |   **Array** | **Contains** |        **196.24 ns** |         **2.264 ns** |         **2.118 ns** |        **196.85 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |   Array | Contains |        171.90 ns |         1.794 ns |         1.498 ns |        171.71 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |   Array | Contains |        215.12 ns |         1.347 ns |         1.260 ns |        215.32 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |    **List** |      **Any** |      **7,848.02 ns** |        **94.039 ns** |        **87.964 ns** |      **7,848.18 ns** |     **8.1329** |     **-** |     **-** |     **12,776 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |    List |      Any |      7,951.35 ns |        57.571 ns |        44.948 ns |      7,946.25 ns |     8.1329 |     - |     - |     12,776 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |    List |      Any |      8,451.05 ns |       296.169 ns |       873.261 ns |      7,983.62 ns |     8.1329 |     - |     - |     12,776 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |    **List** | **Contains** |        **187.17 ns** |         **1.389 ns** |         **1.299 ns** |        **187.67 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |    List | Contains |        167.13 ns |         1.095 ns |         1.024 ns |        167.42 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |    List | Contains |        203.80 ns |         1.640 ns |         1.534 ns |        203.41 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** | **HashSet** |      **Any** |      **7,796.46 ns** |       **109.566 ns** |        **97.128 ns** |      **7,787.22 ns** |     **8.1329** |     **-** |     **-** |     **12,776 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 | HashSet |      Any |      7,970.82 ns |        75.520 ns |        70.641 ns |      7,975.86 ns |     8.1329 |     - |     - |     12,776 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 | HashSet |      Any |      7,984.78 ns |       105.235 ns |       140.485 ns |      7,931.87 ns |     8.1329 |     - |     - |     12,776 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** | **HashSet** | **Contains** |         **22.35 ns** |         **0.106 ns** |         **0.099 ns** |         **22.36 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 | HashSet | Contains |         26.35 ns |         0.150 ns |         0.140 ns |         26.30 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 | HashSet | Contains |         28.21 ns |         0.242 ns |         0.226 ns |         28.15 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |   **Array** |      **Any** |  **8,340,604.13 ns** |    **69,898.593 ns** |    **61,963.282 ns** |  **8,316,328.91 ns** | **10625.0000** |     **-** |     **-** | **16,677,912 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |   Array |      Any |  8,205,579.27 ns |    68,824.484 ns |    64,378.465 ns |  8,222,203.12 ns | 10625.0000 |     - |     - | 16,677,913 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |   Array |      Any |  8,172,045.73 ns |    63,150.981 ns |    59,071.467 ns |  8,170,517.19 ns | 10625.0000 |     - |     - | 16,677,912 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |   **Array** | **Contains** |    **228,322.91 ns** |     **2,562.956 ns** |     **2,271.994 ns** |    **228,350.27 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |   Array | Contains |    207,584.99 ns |     1,245.636 ns |     1,040.163 ns |    207,601.81 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |   Array | Contains |    231,154.27 ns |     3,959.025 ns |     3,703.274 ns |    230,457.02 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |    **List** |      **Any** | **10,497,386.42 ns** |    **74,989.043 ns** |    **62,619.247 ns** | **10,497,498.44 ns** | **10625.0000** |     **-** |     **-** | **16,677,920 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |    List |      Any | 10,256,639.00 ns |   106,184.820 ns |    88,669.134 ns | 10,241,783.59 ns | 10625.0000 |     - |     - | 16,677,921 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |    List |      Any | 10,409,196.09 ns |    76,720.264 ns |    68,010.516 ns | 10,412,827.34 ns | 10625.0000 |     - |     - | 16,677,920 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** |    **List** | **Contains** |    **231,522.40 ns** |     **2,083.541 ns** |     **1,948.945 ns** |    **230,173.91 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |    List | Contains |    212,844.96 ns |     2,955.163 ns |     2,764.261 ns |    212,310.78 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |    List | Contains |    239,879.47 ns |     2,027.118 ns |     1,896.167 ns |    239,139.50 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** | **HashSet** |      **Any** | **10,415,665.36 ns** |    **83,864.617 ns** |    **78,447.015 ns** | **10,442,624.22 ns** | **10625.0000** |     **-** |     **-** | **16,674,824 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 | HashSet |      Any | 10,350,060.04 ns |    57,827.805 ns |    51,262.843 ns | 10,348,811.72 ns | 10625.0000 |     - |     - | 16,674,825 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 | HashSet |      Any | 10,827,898.28 ns |    63,264.013 ns |    59,177.197 ns | 10,836,882.03 ns | 10625.0000 |     - |     - | 16,674,824 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** | **HashSet** | **Contains** |         **23.81 ns** |         **0.151 ns** |         **0.142 ns** |         **23.76 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 | HashSet | Contains |         28.14 ns |         0.161 ns |         0.142 ns |         28.17 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 | HashSet | Contains |         28.97 ns |         0.377 ns |         0.294 ns |         28.90 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |   **Array** |      **Any** |        **611.35 ns** |         **6.021 ns** |         **5.632 ns** |        **610.48 ns** |     **0.0763** |     **-** |     **-** |        **120 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 |   Array |      Any |        540.63 ns |         3.811 ns |         3.565 ns |        540.55 ns |     0.0763 |     - |     - |        120 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |   Array |      Any |        540.08 ns |         2.997 ns |         2.503 ns |        539.41 ns |     0.0763 |     - |     - |        120 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |   **Array** | **Contains** |        **194.58 ns** |         **1.564 ns** |         **1.221 ns** |        **194.57 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 |   Array | Contains |        191.23 ns |         1.079 ns |         0.957 ns |        191.27 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |   Array | Contains |        224.98 ns |         1.443 ns |         1.127 ns |        225.13 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |    **List** |      **Any** |        **791.26 ns** |         **3.579 ns** |         **3.348 ns** |        **791.73 ns** |     **0.0811** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 |    List |      Any |        864.86 ns |         5.231 ns |         4.084 ns |        865.07 ns |     0.0811 |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |    List |      Any |        881.88 ns |         4.402 ns |         3.903 ns |        881.62 ns |     0.0811 |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |    **List** | **Contains** |        **238.74 ns** |         **1.186 ns** |         **1.109 ns** |        **238.96 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 |    List | Contains |        226.42 ns |         1.392 ns |         1.162 ns |        226.50 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |    List | Contains |        236.49 ns |         1.613 ns |         1.509 ns |        236.61 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** | **HashSet** |      **Any** |        **866.94 ns** |         **3.819 ns** |         **3.572 ns** |        **867.19 ns** |     **0.0811** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 | HashSet |      Any |        846.93 ns |         2.176 ns |         2.035 ns |        847.49 ns |     0.0811 |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 | HashSet |      Any |        924.68 ns |         3.257 ns |         2.720 ns |        925.44 ns |     0.0811 |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** | **HashSet** | **Contains** |         **35.69 ns** |         **0.260 ns** |         **0.217 ns** |         **35.74 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |     100 | HashSet | Contains |         39.55 ns |         0.253 ns |         0.224 ns |         39.60 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 | HashSet | Contains |         47.40 ns |         0.179 ns |         0.167 ns |         47.41 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |   **Array** |      **Any** |      **5,705.63 ns** |        **32.304 ns** |        **28.637 ns** |      **5,709.13 ns** |     **0.0763** |     **-** |     **-** |        **120 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |   Array |      Any |      5,843.15 ns |        31.997 ns |        29.930 ns |      5,847.82 ns |     0.0763 |     - |     - |        120 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |   Array |      Any |      6,230.72 ns |        32.393 ns |        28.715 ns |      6,238.48 ns |     0.0763 |     - |     - |        120 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |   **Array** | **Contains** |      **1,958.34 ns** |        **10.103 ns** |         **8.956 ns** |      **1,960.14 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |   Array | Contains |      1,901.77 ns |        16.888 ns |        15.797 ns |      1,899.62 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |   Array | Contains |      2,194.42 ns |        15.953 ns |        14.142 ns |      2,195.50 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |    **List** |      **Any** |      **9,208.25 ns** |        **46.468 ns** |        **43.466 ns** |      **9,205.23 ns** |     **0.0763** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |    List |      Any |      9,589.18 ns |        65.907 ns |        61.650 ns |      9,566.69 ns |     0.0763 |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |    List |      Any |      9,266.36 ns |        45.710 ns |        42.757 ns |      9,269.10 ns |     0.0763 |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |    **List** | **Contains** |      **2,709.31 ns** |        **12.752 ns** |        **11.929 ns** |      **2,713.46 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |    List | Contains |      2,343.58 ns |        14.848 ns |        13.889 ns |      2,345.55 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |    List | Contains |      2,247.72 ns |        11.898 ns |        10.548 ns |      2,247.16 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** | **HashSet** |      **Any** |      **9,795.54 ns** |        **43.826 ns** |        **40.995 ns** |      **9,808.40 ns** |     **0.0763** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 | HashSet |      Any |      9,536.36 ns |        47.602 ns |        39.750 ns |      9,541.15 ns |     0.0763 |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 | HashSet |      Any |     10,426.26 ns |        46.414 ns |        43.416 ns |     10,424.03 ns |     0.0763 |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** | **HashSet** | **Contains** |         **36.72 ns** |         **0.168 ns** |         **0.149 ns** |         **36.72 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String |   10000 | HashSet | Contains |         40.39 ns |         0.197 ns |         0.185 ns |         40.40 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 | HashSet | Contains |         50.36 ns |         1.033 ns |         1.189 ns |         50.82 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |   **Array** |      **Any** | **29,714,173.83 ns** |   **573,003.736 ns** |   **562,766.286 ns** | **29,954,543.75 ns** |          **-** |     **-** |     **-** |        **120 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |   Array |      Any | 28,697,692.36 ns |   559,689.286 ns |   598,861.266 ns | 28,338,584.38 ns |          - |     - |     - |        124 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |   Array |      Any | 29,852,935.85 ns |   586,031.214 ns |   601,810.911 ns | 30,060,750.00 ns |          - |     - |     - |        120 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |   **Array** | **Contains** | **17,363,977.01 ns** |    **66,562.323 ns** |    **59,005.766 ns** | **17,340,631.25 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |   Array | Contains | 17,119,281.61 ns |    37,092.092 ns |    30,973.577 ns | 17,111,482.81 ns |          - |     - |     - |          2 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |   Array | Contains | 17,656,463.02 ns |   311,764.393 ns |   291,624.606 ns | 17,495,742.19 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |    **List** |      **Any** | **43,925,167.22 ns** |   **867,064.628 ns** | **1,495,643.882 ns** | **43,039,604.55 ns** |          **-** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |    List |      Any | 43,362,599.26 ns |   865,161.150 ns | 1,397,073.991 ns | 43,941,350.00 ns |          - |     - |     - |        132 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |    List |      Any | 42,370,291.03 ns |   245,026.429 ns |   204,608.165 ns | 42,321,575.00 ns |          - |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** |    **List** | **Contains** | **20,266,473.44 ns** |    **84,041.611 ns** |    **65,614.162 ns** | **20,258,210.94 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 |    List | Contains | 20,119,386.38 ns |    99,130.142 ns |    87,876.289 ns | 20,098,134.38 ns |          - |     - |     - |          2 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 |    List | Contains | 18,504,964.90 ns |   107,887.601 ns |   100,918.128 ns | 18,505,114.06 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** | **HashSet** |      **Any** | **41,918,210.00 ns** |   **280,645.233 ns** |   **262,515.725 ns** | **41,974,391.67 ns** |          **-** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | HashSet |      Any | 41,846,891.67 ns |   255,732.370 ns |   226,700.085 ns | 41,706,600.00 ns |          - |     - |     - |        132 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | HashSet |      Any | 52,009,716.57 ns | 2,596,163.202 ns | 7,018,878.181 ns | 50,021,475.00 ns |          - |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** | **HashSet** | **Contains** |         **41.34 ns** |         **1.902 ns** |         **5.332 ns** |         **39.40 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | HashSet | Contains |         44.12 ns |         1.649 ns |         4.706 ns |         42.30 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | HashSet | Contains |         48.98 ns |         1.431 ns |         4.036 ns |         46.70 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |   **Array** |      **Any** |      **1,616.86 ns** |        **17.564 ns** |        **17.250 ns** |      **1,612.46 ns** |     **0.0763** |     **-** |     **-** |        **120 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |   Array |      Any |      1,587.36 ns |        25.500 ns |        21.294 ns |      1,579.93 ns |     0.0763 |     - |     - |        120 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |   Array |      Any |      1,670.46 ns |        12.137 ns |        10.759 ns |      1,667.90 ns |     0.0763 |     - |     - |        120 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |   **Array** | **Contains** |        **841.66 ns** |         **2.473 ns** |         **2.192 ns** |        **841.58 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |   Array | Contains |        836.50 ns |         2.730 ns |         2.420 ns |        836.53 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |   Array | Contains |        865.13 ns |         5.695 ns |         4.755 ns |        863.62 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |    **List** |      **Any** |      **2,217.12 ns** |        **27.180 ns** |        **22.696 ns** |      **2,212.12 ns** |     **0.0801** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |    List |      Any |      2,294.44 ns |        17.701 ns |        16.558 ns |      2,299.30 ns |     0.0801 |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |    List |      Any |      2,209.37 ns |        21.473 ns |        20.085 ns |      2,211.05 ns |     0.0801 |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |    **List** | **Contains** |        **719.36 ns** |        **10.116 ns** |         **8.448 ns** |        **717.22 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |    List | Contains |        728.89 ns |         5.176 ns |         4.588 ns |        729.65 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |    List | Contains |        666.02 ns |         4.075 ns |         3.613 ns |        665.25 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** | **HashSet** |      **Any** |      **2,210.86 ns** |         **9.669 ns** |         **8.572 ns** |      **2,212.13 ns** |     **0.0801** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 | HashSet |      Any |      2,314.85 ns |        15.258 ns |        13.525 ns |      2,314.94 ns |     0.0801 |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 | HashSet |      Any |      2,348.02 ns |         9.489 ns |         8.412 ns |      2,349.79 ns |     0.0801 |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** | **HashSet** | **Contains** |         **75.86 ns** |         **0.608 ns** |         **0.539 ns** |         **75.92 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |     100 | HashSet | Contains |         80.94 ns |         0.589 ns |         0.522 ns |         80.96 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 | HashSet | Contains |         76.44 ns |         0.473 ns |         0.420 ns |         76.49 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |   **Array** |      **Any** |    **122,134.60 ns** |     **1,445.167 ns** |     **1,351.810 ns** |    **121,840.41 ns** |          **-** |     **-** |     **-** |        **120 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |   Array |      Any |    119,045.33 ns |     1,121.214 ns |     1,048.785 ns |    118,892.96 ns |          - |     - |     - |        120 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |   Array |      Any |    114,577.48 ns |       761.249 ns |       712.073 ns |    114,596.39 ns |          - |     - |     - |        120 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |   **Array** | **Contains** |     **74,501.91 ns** |       **631.789 ns** |       **590.976 ns** |     **74,446.33 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |   Array | Contains |     72,867.83 ns |       535.324 ns |       474.551 ns |     73,009.86 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |   Array | Contains |     68,611.14 ns |       715.334 ns |       669.124 ns |     68,546.91 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |    **List** |      **Any** |    **148,249.28 ns** |     **1,187.571 ns** |     **1,110.855 ns** |    **148,028.60 ns** |          **-** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |    List |      Any |    147,127.81 ns |     2,311.993 ns |     2,162.640 ns |    147,154.14 ns |          - |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |    List |      Any |    148,735.03 ns |     1,470.084 ns |     1,303.191 ns |    148,553.16 ns |          - |     - |     - |        129 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |    **List** | **Contains** |     **70,094.09 ns** |       **481.762 ns** |       **376.128 ns** |     **70,135.63 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |    List | Contains |     71,497.54 ns |       753.834 ns |       668.254 ns |     71,373.64 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |    List | Contains |     67,067.90 ns |       640.972 ns |       599.565 ns |     66,978.47 ns |          - |     - |     - |          1 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** | **HashSet** |      **Any** |    **148,066.79 ns** |     **2,112.553 ns** |     **1,872.723 ns** |    **148,029.52 ns** |          **-** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 | HashSet |      Any |    147,508.56 ns |       827.818 ns |       774.341 ns |    147,697.06 ns |          - |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 | HashSet |      Any |    155,257.65 ns |     3,098.765 ns |     3,182.204 ns |    154,469.63 ns |          - |     - |     - |        130 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** | **HashSet** | **Contains** |         **77.25 ns** |         **0.617 ns** |         **0.515 ns** |         **77.25 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 | HashSet | Contains |         81.07 ns |         1.126 ns |         1.383 ns |         80.69 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 | HashSet | Contains |         77.18 ns |         0.382 ns |         0.357 ns |         77.26 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |   **Array** |      **Any** |  **3,733,916.38 ns** |    **29,492.221 ns** |    **26,144.086 ns** |  **3,729,013.87 ns** |          **-** |     **-** |     **-** |        **120 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |   Array |      Any |  3,737,711.61 ns |    21,535.521 ns |    20,144.340 ns |  3,734,800.00 ns |          - |     - |     - |        120 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |   Array |      Any |  3,721,062.70 ns |    65,233.616 ns |    50,930.116 ns |  3,716,828.91 ns |          - |     - |     - |        120 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |   **Array** | **Contains** |  **2,891,763.45 ns** |    **72,617.252 ns** |   **208,352.508 ns** |  **2,881,571.88 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |   Array | Contains |  2,678,377.54 ns |    25,484.430 ns |    23,838.151 ns |  2,669,552.93 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |   Array | Contains |  2,141,687.12 ns |    21,736.656 ns |    18,151.092 ns |  2,136,346.29 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |    **List** |      **Any** |  **4,186,549.04 ns** |    **33,037.552 ns** |    **27,587.852 ns** |  **4,188,864.84 ns** |          **-** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |    List |      Any |  4,445,827.00 ns |   184,680.134 ns |   532,844.412 ns |  4,231,395.31 ns |          - |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |    List |      Any |  4,080,342.00 ns |    79,635.511 ns |   128,596.506 ns |  4,005,839.45 ns |          - |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |    **List** | **Contains** |  **2,458,445.99 ns** |    **19,913.427 ns** |    **18,627.032 ns** |  **2,463,205.08 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |    List | Contains |  2,467,369.51 ns |    16,573.211 ns |    15,502.592 ns |  2,471,346.48 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |    List | Contains |  2,110,872.30 ns |    35,528.165 ns |    27,738.054 ns |  2,100,611.72 ns |          - |     - |     - |            - |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** | **HashSet** |      **Any** |  **4,080,793.26 ns** |    **39,371.786 ns** |    **36,828.393 ns** |  **4,075,801.95 ns** |          **-** |     **-** |     **-** |        **128 B** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 | HashSet |      Any |  4,078,611.77 ns |    29,303.021 ns |    27,410.064 ns |  4,069,647.66 ns |          - |     - |     - |        128 B |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 | HashSet |      Any |  4,013,600.48 ns |    63,999.137 ns |    53,442.178 ns |  3,993,488.28 ns |          - |     - |     - |        128 B |
| **AnyVsContains** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** | **HashSet** | **Contains** |         **79.89 ns** |         **0.609 ns** |         **0.569 ns** |         **79.83 ns** |          **-** |     **-** |     **-** |            **-** |
| AnyVsContains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 | HashSet | Contains |         93.60 ns |         0.428 ns |         0.400 ns |         93.72 ns |          - |     - |     - |            - |
| AnyVsContains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 | HashSet | Contains |         77.73 ns |         0.882 ns |         0.825 ns |         77.42 ns |          - |     - |     - |            - |