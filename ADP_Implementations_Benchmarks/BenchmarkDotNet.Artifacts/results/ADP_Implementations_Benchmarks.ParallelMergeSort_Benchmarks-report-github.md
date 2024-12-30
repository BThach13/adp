```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-LKNGGC : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method                     | N      | Mean          | Error         | StdDev        | Median        | Gen0      | Gen1      | Allocated  |
|--------------------------- |------- |--------------:|--------------:|--------------:|--------------:|----------:|----------:|-----------:|
| **ParallelSortWithTreshold1**  | **10**     |     **38.039 μs** |     **2.9931 μs** |     **8.6834 μs** |     **37.400 μs** |         **-** |         **-** |     **5768 B** |
| ParallelSortWithTreshold2  | 10     |     44.124 μs |     4.5919 μs |    12.9517 μs |     44.050 μs |         - |         - |     5880 B |
| ParallelSortWithTreshold4  | 10     |     46.853 μs |     3.8360 μs |    11.0063 μs |     45.550 μs |         - |         - |     5880 B |
| ParallelSortWithTreshold6  | 10     |     43.537 μs |     4.0765 μs |    11.8266 μs |     40.800 μs |         - |         - |     5880 B |
| ParallelSortWithTreshold10 | 10     |      2.299 μs |     0.1119 μs |     0.3281 μs |      2.200 μs |         - |         - |     1528 B |
| ParalleleOnlySort          | 10     |     43.629 μs |     3.2570 μs |     9.3972 μs |     41.800 μs |         - |         - |     5880 B |
| SeqOnlySort                | 10     |      1.917 μs |     0.0784 μs |     0.2249 μs |      1.900 μs |         - |         - |      768 B |
| **ParallelSortWithTreshold1**  | **100**    |     **83.235 μs** |     **5.0780 μs** |    **14.8930 μs** |     **85.100 μs** |         **-** |         **-** |    **56208 B** |
| ParallelSortWithTreshold2  | 100    |     80.410 μs |     6.8668 μs |    19.8122 μs |     79.550 μs |         - |         - |    56320 B |
| ParallelSortWithTreshold4  | 100    |     84.929 μs |     5.7305 μs |    16.5338 μs |     85.400 μs |         - |         - |    56520 B |
| ParallelSortWithTreshold6  | 100    |     88.693 μs |     6.9722 μs |    20.2276 μs |     88.200 μs |         - |         - |    56096 B |
| ParallelSortWithTreshold10 | 100    |     86.940 μs |     5.5471 μs |    16.2688 μs |     89.000 μs |         - |         - |    56320 B |
| ParalleleOnlySort          | 100    |     94.838 μs |     5.5497 μs |    15.8335 μs |     94.300 μs |         - |         - |    56320 B |
| SeqOnlySort                | 100    |     23.843 μs |     0.9683 μs |     2.7784 μs |     24.000 μs |         - |         - |     5624 B |
| **ParallelSortWithTreshold1**  | **1000**   |    **279.575 μs** |     **6.7557 μs** |    **19.1648 μs** |    **277.700 μs** |         **-** |         **-** |   **570752 B** |
| ParallelSortWithTreshold2  | 1000   |    308.522 μs |     6.9246 μs |    19.7563 μs |    306.950 μs |         - |         - |   570776 B |
| ParallelSortWithTreshold4  | 1000   |    301.560 μs |     9.8648 μs |    28.3038 μs |    299.300 μs |         - |         - |   571320 B |
| ParallelSortWithTreshold6  | 1000   |    282.017 μs |     7.3001 μs |    20.3497 μs |    277.850 μs |         - |         - |   570240 B |
| ParallelSortWithTreshold10 | 1000   |    314.819 μs |     7.4977 μs |    21.5124 μs |    314.000 μs |         - |         - |   570896 B |
| ParalleleOnlySort          | 1000   |    282.638 μs |     6.9661 μs |    19.7616 μs |    281.100 μs |         - |         - |   571296 B |
| SeqOnlySort                | 1000   |    230.887 μs |     4.5063 μs |    11.3880 μs |    229.500 μs |         - |         - |    64728 B |
| **ParallelSortWithTreshold1**  | **10000**  |  **2,680.263 μs** |   **113.5534 μs** |   **334.8148 μs** |  **2,640.600 μs** |         **-** |         **-** |  **5835952 B** |
| ParallelSortWithTreshold2  | 10000  |  2,527.801 μs |   138.5772 μs |   404.2364 μs |  2,441.400 μs |         - |         - |  5835880 B |
| ParallelSortWithTreshold4  | 10000  |  2,569.045 μs |   151.6975 μs |   440.1020 μs |  2,421.400 μs |         - |         - |  5836744 B |
| ParallelSortWithTreshold6  | 10000  |  2,459.089 μs |    84.4207 μs |   244.9198 μs |  2,475.400 μs |         - |         - |  5836856 B |
| ParallelSortWithTreshold10 | 10000  |  2,599.945 μs |   130.0672 μs |   383.5060 μs |  2,652.500 μs |         - |         - |  5835520 B |
| ParalleleOnlySort          | 10000  |  2,584.200 μs |   161.3736 μs |   468.1740 μs |  2,509.400 μs |         - |         - |  5836880 B |
| SeqOnlySort                | 10000  |  1,902.305 μs |   254.3988 μs |   750.1006 μs |  2,255.500 μs |         - |         - |   792440 B |
| **ParallelSortWithTreshold1**  | **100000** | **20,649.171 μs** | **2,193.8750 μs** | **6,434.2562 μs** | **17,117.400 μs** | **9000.0000** |         **-** | **59634712 B** |
| ParallelSortWithTreshold2  | 100000 | 20,125.658 μs | 1,767.2242 μs | 5,098.8463 μs | 17,761.000 μs | 9000.0000 |         - | 59637624 B |
| ParallelSortWithTreshold4  | 100000 | 17,507.568 μs |   516.2535 μs | 1,377.9851 μs | 17,099.250 μs | 9000.0000 | 1000.0000 | 59636720 B |
| ParallelSortWithTreshold6  | 100000 | 20,099.330 μs |   546.9119 μs | 1,459.8188 μs | 19,725.000 μs | 9000.0000 |         - | 59637112 B |
| ParallelSortWithTreshold10 | 100000 | 19,663.997 μs |   451.9474 μs | 1,237.1989 μs | 19,368.100 μs | 9000.0000 |         - | 59636680 B |
| ParalleleOnlySort          | 100000 | 20,142.794 μs |   499.2868 μs | 1,349.8509 μs | 20,176.900 μs | 9000.0000 | 1000.0000 | 59637344 B |
| SeqOnlySort                | 100000 |  9,573.760 μs |   190.2120 μs |   542.6857 μs |  9,503.750 μs | 1000.0000 |         - |  9231608 B |
