``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i5-4310U CPU 2.00GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-preview.5.21302.13
  [Host]        : .NET 6.0.0 (6.0.21.30105), X64 RyuJIT
  .NET 5.0      : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET 6.0      : .NET 6.0.0 (6.0.21.30105), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT


```
|   Method |           Job |       Runtime |    Type |       N |             Mean |            Error |           StdDev |           Median |      Gen 0 | Gen 1 | Gen 2 |    Allocated |
|--------- |-------------- |-------------- |-------- |-------- |-----------------:|-----------------:|-----------------:|-----------------:|-----------:|------:|------:|-------------:|
|      **Any** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |     **100** |        **697.15 ns** |         **7.836 ns** |         **6.118 ns** |        **696.08 ns** |     **0.7544** |     **-** |     **-** |      **1,184 B** |
| Contains |      .NET 5.0 |      .NET 5.0 | Integer |     100 |         19.96 ns |         0.158 ns |         0.147 ns |         19.96 ns |          - |     - |     - |            - |
|   Exists |      .NET 5.0 |      .NET 5.0 | Integer |     100 |        359.26 ns |         3.199 ns |         2.993 ns |        359.81 ns |     0.7291 |     - |     - |      1,144 B |
|      Any |      .NET 6.0 |      .NET 6.0 | Integer |     100 |        728.50 ns |         6.515 ns |         5.775 ns |        729.42 ns |     0.7544 |     - |     - |      1,184 B |
| Contains |      .NET 6.0 |      .NET 6.0 | Integer |     100 |         17.43 ns |         0.169 ns |         0.150 ns |         17.42 ns |          - |     - |     - |            - |
|   Exists |      .NET 6.0 |      .NET 6.0 | Integer |     100 |        360.36 ns |         3.287 ns |         3.075 ns |        359.76 ns |     0.7291 |     - |     - |      1,144 B |
|      Any | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |        697.39 ns |         4.305 ns |         3.817 ns |        697.45 ns |     0.7544 |     - |     - |      1,184 B |
| Contains | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |         22.49 ns |         0.129 ns |         0.114 ns |         22.51 ns |          - |     - |     - |            - |
|   Exists | .NET Core 3.1 | .NET Core 3.1 | Integer |     100 |        365.36 ns |         2.347 ns |         2.195 ns |        365.59 ns |     0.7291 |     - |     - |      1,144 B |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** | **Integer** |   **10000** |      **7,926.44 ns** |        **59.784 ns** |        **52.997 ns** |      **7,912.10 ns** |     **8.1329** |     **-** |     **-** |     **12,776 B** |
| Contains |      .NET 5.0 |      .NET 5.0 | Integer |   10000 |        172.28 ns |         0.893 ns |         0.835 ns |        172.33 ns |          - |     - |     - |            - |
|   Exists |      .NET 5.0 |      .NET 5.0 | Integer |   10000 |      3,928.60 ns |        21.763 ns |        20.357 ns |      3,924.37 ns |     8.1177 |     - |     - |     12,736 B |
|      Any |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |      8,200.19 ns |        49.688 ns |        46.478 ns |      8,200.19 ns |     8.1329 |     - |     - |     12,776 B |
| Contains |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |        147.60 ns |         0.842 ns |         0.788 ns |        147.65 ns |          - |     - |     - |            - |
|   Exists |      .NET 6.0 |      .NET 6.0 | Integer |   10000 |      3,908.92 ns |        23.365 ns |        21.856 ns |      3,911.42 ns |     8.1177 |     - |     - |     12,736 B |
|      Any | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |      7,910.07 ns |        71.745 ns |        67.110 ns |      7,937.24 ns |     8.1329 |     - |     - |     12,776 B |
| Contains | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |        189.71 ns |         1.161 ns |         1.086 ns |        189.94 ns |          - |     - |     - |            - |
|   Exists | .NET Core 3.1 | .NET Core 3.1 | Integer |   10000 |      3,957.03 ns |        36.953 ns |        32.758 ns |      3,949.37 ns |     8.1177 |     - |     - |     12,736 B |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** | **Integer** | **1000000** | **10,799,078.91 ns** |    **81,631.059 ns** |    **68,165.631 ns** | **10,798,680.47 ns** | **10625.0000** |     **-** |     **-** | **16,677,920 B** |
| Contains |      .NET 5.0 |      .NET 5.0 | Integer | 1000000 |    232,501.73 ns |     2,765.400 ns |     2,451.455 ns |    232,960.22 ns |          - |     - |     - |            - |
|   Exists |      .NET 5.0 |      .NET 5.0 | Integer | 1000000 |  5,177,235.73 ns |    29,093.351 ns |    27,213.939 ns |  5,187,654.69 ns | 10632.8125 |     - |     - | 16,677,880 B |
|      Any |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |  9,864,624.55 ns |    35,131.445 ns |    31,143.111 ns |  9,861,809.38 ns | 10625.0000 |     - |     - | 16,677,921 B |
| Contains |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |    203,497.86 ns |     3,459.582 ns |     3,236.095 ns |    203,150.71 ns |          - |     - |     - |            - |
|   Exists |      .NET 6.0 |      .NET 6.0 | Integer | 1000000 |  5,504,885.02 ns |   109,164.955 ns |   295,133.804 ns |  5,470,546.88 ns | 10632.8125 |     - |     - | 16,677,880 B |
|      Any | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 | 10,732,622.79 ns |   218,669.790 ns |   634,400.711 ns | 10,603,617.19 ns | 10625.0000 |     - |     - | 16,677,920 B |
| Contains | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |    234,562.86 ns |     1,626.747 ns |     1,442.069 ns |    234,657.31 ns |          - |     - |     - |            - |
|   Exists | .NET Core 3.1 | .NET Core 3.1 | Integer | 1000000 |  5,044,150.33 ns |    32,000.897 ns |    28,367.961 ns |  5,039,316.80 ns | 10632.8125 |     - |     - | 16,677,880 B |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **String** |     **100** |        **770.45 ns** |         **4.235 ns** |         **3.961 ns** |        **772.13 ns** |     **0.0811** |     **-** |     **-** |        **128 B** |
| Contains |      .NET 5.0 |      .NET 5.0 |  String |     100 |        217.71 ns |         2.037 ns |         1.905 ns |        217.24 ns |          - |     - |     - |            - |
|   Exists |      .NET 5.0 |      .NET 5.0 |  String |     100 |        243.47 ns |         3.019 ns |         2.677 ns |        243.26 ns |     0.0558 |     - |     - |         88 B |
|      Any |      .NET 6.0 |      .NET 6.0 |  String |     100 |        772.43 ns |         4.210 ns |         4.679 ns |        773.19 ns |     0.0811 |     - |     - |        128 B |
| Contains |      .NET 6.0 |      .NET 6.0 |  String |     100 |        197.85 ns |         1.499 ns |         1.251 ns |        197.60 ns |          - |     - |     - |            - |
|   Exists |      .NET 6.0 |      .NET 6.0 |  String |     100 |        246.99 ns |         1.662 ns |         1.555 ns |        246.91 ns |     0.0558 |     - |     - |         88 B |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |        770.54 ns |         4.084 ns |         3.821 ns |        769.55 ns |     0.0811 |     - |     - |        128 B |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |        220.10 ns |         2.104 ns |         1.865 ns |        219.59 ns |          - |     - |     - |            - |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  String |     100 |        259.03 ns |         1.861 ns |         1.650 ns |        259.43 ns |     0.0558 |     - |     - |         88 B |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **String** |   **10000** |      **8,895.13 ns** |        **69.511 ns** |        **65.020 ns** |      **8,867.77 ns** |     **0.0763** |     **-** |     **-** |        **128 B** |
| Contains |      .NET 5.0 |      .NET 5.0 |  String |   10000 |      2,673.82 ns |        15.987 ns |        14.954 ns |      2,675.40 ns |          - |     - |     - |            - |
|   Exists |      .NET 5.0 |      .NET 5.0 |  String |   10000 |      2,458.62 ns |        14.035 ns |        12.442 ns |      2,463.66 ns |     0.0534 |     - |     - |         88 B |
|      Any |      .NET 6.0 |      .NET 6.0 |  String |   10000 |      8,708.88 ns |        66.082 ns |        61.814 ns |      8,727.29 ns |     0.0763 |     - |     - |        128 B |
| Contains |      .NET 6.0 |      .NET 6.0 |  String |   10000 |      2,140.50 ns |         9.886 ns |         9.248 ns |      2,142.92 ns |          - |     - |     - |            - |
|   Exists |      .NET 6.0 |      .NET 6.0 |  String |   10000 |      2,761.27 ns |        54.814 ns |       109.470 ns |      2,741.94 ns |     0.0534 |     - |     - |         88 B |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |     11,279.33 ns |       734.374 ns |     2,165.318 ns |     10,009.40 ns |     0.0763 |     - |     - |        128 B |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |      2,219.33 ns |        40.438 ns |        33.767 ns |      2,208.27 ns |          - |     - |     - |            - |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  String |   10000 |      2,462.05 ns |        12.474 ns |        11.668 ns |      2,459.71 ns |     0.0534 |     - |     - |         88 B |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **String** | **1000000** | **43,975,168.12 ns** | **1,918,879.325 ns** | **5,220,452.723 ns** | **41,150,325.00 ns** |          **-** |     **-** |     **-** |        **128 B** |
| Contains |      .NET 5.0 |      .NET 5.0 |  String | 1000000 | 20,536,948.33 ns |   204,825.521 ns |   191,593.919 ns | 20,514,503.12 ns |          - |     - |     - |            - |
|   Exists |      .NET 5.0 |      .NET 5.0 |  String | 1000000 | 19,570,175.62 ns |   137,609.820 ns |   128,720.311 ns | 19,568,925.00 ns |          - |     - |     - |         88 B |
|      Any |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | 41,588,168.49 ns |   820,406.054 ns | 1,252,846.693 ns | 41,204,130.77 ns |          - |     - |     - |        145 B |
| Contains |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | 20,876,551.95 ns |   380,569.278 ns |   373,769.917 ns | 20,899,528.12 ns |          - |     - |     - |          2 B |
|   Exists |      .NET 6.0 |      .NET 6.0 |  String | 1000000 | 19,874,227.64 ns |   333,904.677 ns |   278,825.528 ns | 19,786,218.75 ns |          - |     - |     - |         90 B |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | 40,155,831.95 ns |   191,432.150 ns |   159,854.516 ns | 40,231,061.54 ns |          - |     - |     - |        128 B |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | 18,654,170.31 ns |   171,151.864 ns |   160,095.559 ns | 18,643,848.44 ns |          - |     - |     - |            - |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  String | 1000000 | 19,650,898.54 ns |   287,144.072 ns |   268,594.743 ns | 19,611,115.62 ns |          - |     - |     - |         88 B |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |     **100** |      **2,042.10 ns** |        **13.665 ns** |        **12.782 ns** |      **2,043.38 ns** |     **0.0801** |     **-** |     **-** |        **128 B** |
| Contains |      .NET 5.0 |      .NET 5.0 |  Record |     100 |        717.05 ns |         7.060 ns |         6.604 ns |        720.61 ns |          - |     - |     - |            - |
|   Exists |      .NET 5.0 |      .NET 5.0 |  Record |     100 |        917.10 ns |         7.326 ns |         6.494 ns |        918.59 ns |     0.0553 |     - |     - |         88 B |
|      Any |      .NET 6.0 |      .NET 6.0 |  Record |     100 |      2,117.77 ns |        16.021 ns |        14.986 ns |      2,115.89 ns |     0.0801 |     - |     - |        128 B |
| Contains |      .NET 6.0 |      .NET 6.0 |  Record |     100 |        708.72 ns |         3.648 ns |         3.412 ns |        709.16 ns |          - |     - |     - |            - |
|   Exists |      .NET 6.0 |      .NET 6.0 |  Record |     100 |        981.53 ns |         9.371 ns |         7.316 ns |        979.63 ns |     0.0553 |     - |     - |         88 B |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |      2,385.78 ns |         9.647 ns |         8.552 ns |      2,385.23 ns |     0.0801 |     - |     - |        128 B |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |        748.86 ns |         5.059 ns |         4.485 ns |        749.27 ns |          - |     - |     - |            - |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  Record |     100 |        913.49 ns |         6.941 ns |         6.493 ns |        914.09 ns |     0.0553 |     - |     - |         88 B |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **Record** |   **10000** |    **144,982.22 ns** |     **1,749.169 ns** |     **1,636.174 ns** |    **145,137.24 ns** |          **-** |     **-** |     **-** |        **128 B** |
| Contains |      .NET 5.0 |      .NET 5.0 |  Record |   10000 |     69,823.77 ns |       457.964 ns |       405.973 ns |     69,768.35 ns |          - |     - |     - |            - |
|   Exists |      .NET 5.0 |      .NET 5.0 |  Record |   10000 |     78,844.61 ns |       680.968 ns |       636.978 ns |     78,858.72 ns |          - |     - |     - |         88 B |
|      Any |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |    140,763.48 ns |     1,054.560 ns |       880.605 ns |    140,942.59 ns |          - |     - |     - |        128 B |
| Contains |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |     70,658.46 ns |       813.600 ns |       721.235 ns |     70,631.31 ns |          - |     - |     - |            - |
|   Exists |      .NET 6.0 |      .NET 6.0 |  Record |   10000 |     79,813.81 ns |       501.750 ns |       469.337 ns |     79,682.61 ns |          - |     - |     - |         88 B |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |    150,348.82 ns |     1,791.063 ns |     1,675.361 ns |    149,715.62 ns |          - |     - |     - |        128 B |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |     66,738.75 ns |       652.861 ns |       578.744 ns |     66,645.23 ns |          - |     - |     - |            - |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  Record |   10000 |     76,049.92 ns |       676.491 ns |       632.790 ns |     75,727.76 ns |          - |     - |     - |         88 B |
|      **Any** |      **.NET 5.0** |      **.NET 5.0** |  **Record** | **1000000** |  **3,911,894.05 ns** |    **26,284.932 ns** |    **21,949.109 ns** |  **3,915,730.47 ns** |          **-** |     **-** |     **-** |        **128 B** |
| Contains |      .NET 5.0 |      .NET 5.0 |  Record | 1000000 |  2,463,170.90 ns |    20,953.162 ns |    18,574.433 ns |  2,459,449.61 ns |          - |     - |     - |            - |
|   Exists |      .NET 5.0 |      .NET 5.0 |  Record | 1000000 |  2,583,132.51 ns |    50,457.143 ns |    63,812.130 ns |  2,548,226.17 ns |          - |     - |     - |         88 B |
|      Any |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |  4,042,020.93 ns |    73,405.880 ns |    65,072.401 ns |  4,061,818.75 ns |          - |     - |     - |        128 B |
| Contains |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |  2,542,479.45 ns |    50,547.818 ns |    69,190.424 ns |  2,526,505.47 ns |          - |     - |     - |            - |
|   Exists |      .NET 6.0 |      .NET 6.0 |  Record | 1000000 |  2,800,445.50 ns |    54,602.840 ns |    80,036.135 ns |  2,812,802.73 ns |          - |     - |     - |         88 B |
|      Any | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |  4,402,669.61 ns |    87,814.871 ns |   251,957.326 ns |  4,382,217.58 ns |          - |     - |     - |        128 B |
| Contains | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |  2,215,923.45 ns |    62,271.784 ns |   175,638.670 ns |  2,120,840.23 ns |          - |     - |     - |            - |
|   Exists | .NET Core 3.1 | .NET Core 3.1 |  Record | 1000000 |  2,770,223.96 ns |    54,690.783 ns |    94,338.914 ns |  2,754,053.32 ns |          - |     - |     - |         88 B |