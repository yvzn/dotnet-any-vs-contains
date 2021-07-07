``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i5-4310U CPU 2.00GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.5.21302.13
  [Host]        : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT
  .NET 5.0      : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET 6.0      : .NET 6.0.0 (6.0.21.30105), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT


```
|   Method |           Job |       Runtime |    Type |       N |             Mean |          Error |           StdDev |           Median |
|--------- |-------------- |-------------- |-------- |-------- |-----------------:|---------------:|-----------------:|-----------------:|
|      **Any** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |        **699.53 ns** |       **3.597 ns** |         **3.364 ns** |        **700.24 ns** |
| Contains |      .NET 5.0 |      .NET 5.0 | Integer |     100 |         29.66 ns |       0.302 ns |         0.283 ns |         29.53 ns |
|   Exists |      .NET 5.0 |      .NET 5.0 | Integer |     100 |        409.04 ns |      16.034 ns |        45.486 ns |        376.99 ns |
|      Any |      .NET 6.0 |      .NET 6.0 | Integer |     100 |        713.89 ns |       6.074 ns |         5.681 ns |        710.20 ns |
| Contains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |         28.31 ns |       0.339 ns |         0.317 ns |         28.23 ns |
|   Exists |      .NET 6.0 |      .NET 6.0 | Integer |     100 |        371.33 ns |       2.628 ns |         2.458 ns |        370.52 ns |
|      Any | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |        695.10 ns |       4.317 ns |         3.827 ns |        696.97 ns |
| Contains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |         32.18 ns |       0.232 ns |         0.206 ns |         32.10 ns |
|   Exists | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |        428.37 ns |       1.418 ns |         1.326 ns |        427.63 ns |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |      **7,599.43 ns** |      **51.023 ns** |        **45.231 ns** |      **7,614.62 ns** |
| Contains |      .NET 5.0 |      .NET 5.0 | Integer |   10000 |        183.42 ns |       1.641 ns |         1.455 ns |        183.38 ns |
|   Exists |      .NET 5.0 |      .NET 5.0 | Integer |   10000 |      3,910.41 ns |      43.404 ns |        40.600 ns |      3,912.43 ns |
|      Any |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |      8,004.32 ns |      66.923 ns |        59.325 ns |      8,016.79 ns |
| Contains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |        161.42 ns |       1.015 ns |         0.900 ns |        161.78 ns |
|   Exists |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |      3,917.43 ns |      44.849 ns |        39.758 ns |      3,924.39 ns |
|      Any | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |      7,638.45 ns |      77.742 ns |        72.720 ns |      7,653.56 ns |
| Contains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |        186.65 ns |       1.502 ns |         1.254 ns |        186.08 ns |
|   Exists | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |      3,993.25 ns |      32.524 ns |        27.159 ns |      3,997.90 ns |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** | **10,707,577.34 ns** |  **43,756.405 ns** |    **38,788.913 ns** | **10,706,909.38 ns** |
| Contains |      .NET 5.0 |      .NET 5.0 | Integer | 1000000 |    242,167.04 ns |   1,913.781 ns |     1,790.152 ns |    242,803.37 ns |
|   Exists |      .NET 5.0 |      .NET 5.0 | Integer | 1000000 |  5,054,544.69 ns |  29,407.247 ns |    27,507.557 ns |  5,055,607.81 ns |
|      Any |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 | 10,094,860.49 ns |  35,273.377 ns |    31,268.930 ns | 10,101,637.50 ns |
| Contains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |    204,485.65 ns |   1,558.831 ns |     1,458.132 ns |    204,931.84 ns |
|   Exists |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |  5,047,571.88 ns |  38,686.361 ns |    34,294.451 ns |  5,034,545.31 ns |
|      Any | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 | 10,231,391.04 ns |  85,825.141 ns |    80,280.890 ns | 10,227,542.19 ns |
| Contains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |    235,890.35 ns |   2,008.357 ns |     1,878.618 ns |    236,643.99 ns |
|   Exists | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |  5,103,247.86 ns |  33,867.434 ns |    31,679.619 ns |  5,093,966.41 ns |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |        **768.53 ns** |       **5.012 ns** |         **4.443 ns** |        **770.80 ns** |
| Contains |      .NET 5.0 |      .NET 5.0 |  String |     100 |        253.94 ns |       2.507 ns |         2.345 ns |        253.33 ns |
|   Exists |      .NET 5.0 |      .NET 5.0 |  String |     100 |        253.33 ns |       2.327 ns |         2.176 ns |        252.87 ns |
|      Any |      .NET 6.0 |      .NET 6.0 |  String |     100 |        757.58 ns |       5.785 ns |         5.412 ns |        759.55 ns |
| Contains |      .NET 6.0 |      .NET 6.0 |  String |     100 |        207.74 ns |       0.788 ns |         0.698 ns |        207.55 ns |
|   Exists |      .NET 6.0 |      .NET 6.0 |  String |     100 |        283.65 ns |       1.749 ns |         1.636 ns |        284.13 ns |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |        807.45 ns |       7.824 ns |         6.936 ns |        804.68 ns |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |        219.91 ns |       1.485 ns |         1.316 ns |        220.39 ns |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |        270.93 ns |       2.665 ns |         2.363 ns |        269.74 ns |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |      **8,511.97 ns** |      **11.210 ns** |        **10.486 ns** |      **8,513.02 ns** |
| Contains |      .NET 5.0 |      .NET 5.0 |  String |   10000 |      2,700.32 ns |      16.371 ns |        14.512 ns |      2,704.66 ns |
|   Exists |      .NET 5.0 |      .NET 5.0 |  String |   10000 |      2,641.08 ns |       6.226 ns |         5.199 ns |      2,641.25 ns |
|      Any |      .NET 6.0 |      .NET 6.0 |  String |   10000 |      8,374.26 ns |      64.418 ns |        60.256 ns |      8,408.99 ns |
| Contains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |      2,331.75 ns |      16.432 ns |        15.370 ns |      2,338.97 ns |
|   Exists |      .NET 6.0 |      .NET 6.0 |  String |   10000 |      2,838.33 ns |      18.519 ns |        17.323 ns |      2,832.97 ns |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |      8,566.64 ns |      61.579 ns |        54.589 ns |      8,539.22 ns |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |      2,802.33 ns |     132.946 ns |       374.977 ns |      2,650.34 ns |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |      2,838.20 ns |      56.308 ns |       132.724 ns |      2,796.94 ns |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** | **44,171,230.04 ns** | **865,927.424 ns** | **1,095,120.933 ns** | **44,474,527.27 ns** |
| Contains |      .NET 5.0 |      .NET 5.0 |  String | 1000000 | 21,993,076.43 ns | 439,664.030 ns |   847,083.323 ns | 22,057,150.00 ns |
|   Exists |      .NET 5.0 |      .NET 5.0 |  String | 1000000 | 21,308,456.92 ns | 420,297.056 ns |   372,582.392 ns | 21,282,631.25 ns |
|      Any |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | 44,418,630.37 ns | 819,433.239 ns |   766,498.361 ns | 44,437,911.11 ns |
| Contains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | 21,224,750.61 ns | 416,230.807 ns |   695,428.175 ns | 21,026,292.19 ns |
|   Exists |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | 19,792,853.30 ns | 389,955.102 ns |   417,247.590 ns | 19,905,089.06 ns |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | 46,664,357.05 ns | 928,203.165 ns | 1,360,548.164 ns | 45,897,336.36 ns |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | 19,386,902.01 ns | 366,273.364 ns |   324,691.797 ns | 19,458,020.31 ns |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | 20,052,921.98 ns | 225,418.732 ns |   210,856.822 ns | 20,106,117.19 ns |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |      **2,090.93 ns** |      **14.814 ns** |        **13.133 ns** |      **2,093.16 ns** |
| Contains |      .NET 5.0 |      .NET 5.0 |  Record |     100 |        736.00 ns |       1.515 ns |         1.265 ns |        735.98 ns |
|   Exists |      .NET 5.0 |      .NET 5.0 |  Record |     100 |        933.41 ns |       3.982 ns |         3.725 ns |        934.31 ns |
|      Any |      .NET 6.0 |      .NET 6.0 |  Record |     100 |      2,118.03 ns |       5.236 ns |         4.372 ns |      2,116.97 ns |
| Contains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |        723.48 ns |       5.914 ns |         5.532 ns |        726.04 ns |
|   Exists |      .NET 6.0 |      .NET 6.0 |  Record |     100 |        987.61 ns |       2.421 ns |         2.021 ns |        987.62 ns |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |      2,068.73 ns |      10.057 ns |         9.408 ns |      2,069.06 ns |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |        719.82 ns |       6.823 ns |         6.049 ns |        721.20 ns |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |        935.22 ns |       7.219 ns |         5.636 ns |        937.80 ns |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |    **145,648.69 ns** |   **1,418.646 ns** |     **1,327.003 ns** |    **145,255.43 ns** |
| Contains |      .NET 5.0 |      .NET 5.0 |  Record |   10000 |     69,690.95 ns |     764.164 ns |       677.411 ns |     69,833.25 ns |
|   Exists |      .NET 5.0 |      .NET 5.0 |  Record |   10000 |     77,675.47 ns |     454.169 ns |       379.252 ns |     77,777.40 ns |
|      Any |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |    142,457.98 ns |   2,771.682 ns |     2,722.162 ns |    140,492.97 ns |
| Contains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |     70,374.25 ns |     646.334 ns |       604.581 ns |     70,517.32 ns |
|   Exists |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |     80,460.01 ns |     869.076 ns |       770.413 ns |     80,393.08 ns |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |    145,065.56 ns |   1,324.163 ns |     1,238.623 ns |    145,035.67 ns |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |     66,283.80 ns |     447.308 ns |       349.229 ns |     66,386.93 ns |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |     76,565.75 ns |     212.260 ns |       198.548 ns |     76,616.48 ns |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |  **4,403,449.72 ns** |  **30,133.382 ns** |    **26,712.458 ns** |  **4,408,783.20 ns** |
| Contains |      .NET 5.0 |      .NET 5.0 |  Record | 1000000 |  2,516,389.28 ns |  41,970.028 ns |    41,220.180 ns |  2,501,573.63 ns |
|   Exists |      .NET 5.0 |      .NET 5.0 |  Record | 1000000 |  2,574,629.49 ns |   9,945.235 ns |     9,302.779 ns |  2,576,629.10 ns |
|      Any |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |  4,263,428.37 ns |  84,658.037 ns |   131,802.364 ns |  4,336,621.09 ns |
| Contains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |  2,647,628.48 ns |  52,339.986 ns |    76,719.273 ns |  2,682,272.46 ns |
|   Exists |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |  2,780,352.71 ns |  10,742.621 ns |     9,523.053 ns |  2,781,493.16 ns |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |  4,221,886.41 ns |  83,482.658 ns |   160,842.741 ns |  4,194,243.36 ns |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |  2,118,962.17 ns |  13,727.848 ns |    12,841.038 ns |  2,116,518.16 ns |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |  2,927,548.19 ns |  79,043.463 ns |   221,646.344 ns |  2,850,670.12 ns |
