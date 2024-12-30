```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-SPSTLN : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method                     | N      | Mean             | Error          | StdDev         | Median           | Gen0      | Allocated  |
|--------------------------- |------- |-----------------:|---------------:|---------------:|-----------------:|----------:|-----------:|
| **ParallelSortWithTreshold1**  | **10**     |        **42.136 μs** |      **3.0086 μs** |      **8.7761 μs** |        **41.100 μs** |         **-** |     **5400 B** |
| ParallelSortWithTreshold2  | 10     |        43.388 μs |      3.6078 μs |     10.1759 μs |        42.650 μs |         - |     5400 B |
| ParallelSortWithTreshold4  | 10     |        38.396 μs |      2.9193 μs |      8.4229 μs |        38.400 μs |         - |     5400 B |
| ParallelSortWithTreshold6  | 10     |        46.262 μs |      4.0162 μs |     11.8419 μs |        44.250 μs |         - |     5400 B |
| ParallelSortWithTreshold10 | 10     |         2.282 μs |      0.1157 μs |      0.3337 μs |         2.200 μs |         - |     1160 B |
| ParalleleOnlySort          | 10     |        39.007 μs |      2.9866 μs |      8.6170 μs |        38.750 μs |         - |     5376 B |
| SeqOnlySort                | 10     |         1.217 μs |      0.0610 μs |      0.1730 μs |         1.200 μs |         - |      400 B |
| **ParallelSortWithTreshold1**  | **100**    |       **104.451 μs** |      **6.0911 μs** |     **17.7680 μs** |       **106.100 μs** |         **-** |    **51368 B** |
| ParallelSortWithTreshold2  | 100    |       112.757 μs |      6.1100 μs |     17.6289 μs |       110.600 μs |         - |    51776 B |
| ParallelSortWithTreshold4  | 100    |        92.207 μs |      6.1537 μs |     17.9506 μs |        91.150 μs |         - |    50984 B |
| ParallelSortWithTreshold6  | 100    |       103.910 μs |      5.9496 μs |     17.4492 μs |       103.200 μs |         - |    52640 B |
| ParallelSortWithTreshold10 | 100    |        87.146 μs |      6.1157 μs |     18.0322 μs |        86.750 μs |         - |    50872 B |
| ParalleleOnlySort          | 100    |        86.719 μs |      5.3632 μs |     15.7294 μs |        85.800 μs |         - |    50984 B |
| SeqOnlySort                | 100    |        25.970 μs |      0.7850 μs |      2.2775 μs |        25.400 μs |         - |      400 B |
| **ParallelSortWithTreshold1**  | **1000**   |       **365.195 μs** |      **7.4543 μs** |     **21.6264 μs** |       **361.600 μs** |         **-** |   **506280 B** |
| ParallelSortWithTreshold2  | 1000   |       374.989 μs |     10.5256 μs |     30.7036 μs |       369.350 μs |         - |   505712 B |
| ParallelSortWithTreshold4  | 1000   |       374.805 μs |      7.4636 μs |     20.9289 μs |       375.000 μs |         - |   507136 B |
| ParallelSortWithTreshold6  | 1000   |       371.378 μs |      8.0841 μs |     23.4534 μs |       370.000 μs |         - |   506208 B |
| ParallelSortWithTreshold10 | 1000   |       374.109 μs |      8.3745 μs |     24.0279 μs |       372.700 μs |         - |   507528 B |
| ParalleleOnlySort          | 1000   |       388.733 μs |      8.7196 μs |     24.8776 μs |       383.500 μs |         - |   506712 B |
| SeqOnlySort                | 1000   |       369.758 μs |      6.2354 μs |      4.8682 μs |       371.350 μs |         - |       64 B |
| **ParallelSortWithTreshold1**  | **10000**  |     **9,623.049 μs** |    **488.9180 μs** |  **1,433.9121 μs** |     **9,222.200 μs** |         **-** |  **5044096 B** |
| ParallelSortWithTreshold2  | 10000  |     9,205.474 μs |    297.6187 μs |    834.5549 μs |     9,045.600 μs |         - |  5043904 B |
| ParallelSortWithTreshold4  | 10000  |    10,727.313 μs |    214.0793 μs |    442.1109 μs |    10,836.550 μs |         - |  5044072 B |
| ParallelSortWithTreshold6  | 10000  |     9,812.311 μs |    470.8585 μs |  1,388.3370 μs |     9,716.100 μs |         - |  5043032 B |
| ParallelSortWithTreshold10 | 10000  |     9,124.827 μs |    339.1362 μs |    989.2763 μs |     8,799.400 μs |         - |  5045192 B |
| ParalleleOnlySort          | 10000  |     9,669.779 μs |    299.6990 μs |    859.8927 μs |     9,615.400 μs |         - |  5042712 B |
| SeqOnlySort                | 10000  |    10,742.640 μs |    248.7176 μs |    721.5749 μs |    10,583.800 μs |         - |      400 B |
| **ParallelSortWithTreshold1**  | **100000** |   **720,748.936 μs** |  **7,216.3031 μs** |  **6,397.0648 μs** |   **720,845.650 μs** | **8000.0000** | **50402776 B** |
| ParallelSortWithTreshold2  | 100000 |   730,435.350 μs | 12,504.5911 μs | 11,084.9943 μs |   726,885.350 μs | 8000.0000 | 50402304 B |
| ParallelSortWithTreshold4  | 100000 |   725,707.753 μs |  8,999.3492 μs |  8,417.9968 μs |   724,022.400 μs | 8000.0000 | 50402464 B |
| ParallelSortWithTreshold6  | 100000 |   725,115.807 μs |  8,074.2203 μs |  7,552.6307 μs |   726,753.300 μs | 8000.0000 | 50402904 B |
| ParallelSortWithTreshold10 | 100000 |   750,198.440 μs |  9,407.0640 μs |  8,799.3735 μs |   748,002.300 μs | 8000.0000 | 50403168 B |
| ParalleleOnlySort          | 100000 |   779,505.364 μs | 18,952.3966 μs | 53,455.5746 μs |   756,149.600 μs | 8000.0000 | 50407872 B |
| SeqOnlySort                | 100000 | 1,007,648.140 μs |  4,617.1826 μs |  4,318.9155 μs | 1,006,959.200 μs |         - |      400 B |
