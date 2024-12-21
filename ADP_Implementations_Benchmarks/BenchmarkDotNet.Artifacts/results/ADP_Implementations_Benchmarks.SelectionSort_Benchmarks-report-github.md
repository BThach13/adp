```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-DQKHUE : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method         | N      | Mean             | Error          | StdDev         | Median           | Allocated |
|--------------- |------- |-----------------:|---------------:|---------------:|-----------------:|----------:|
| **SortAscending**  | **10**     |         **1.436 μs** |      **0.0755 μs** |      **0.2202 μs** |         **1.400 μs** |     **400 B** |
| SortDescending | 10     |         1.509 μs |      0.0929 μs |      0.2710 μs |         1.400 μs |     400 B |
| **SortAscending**  | **100**    |        **24.356 μs** |      **1.1136 μs** |      **3.2485 μs** |        **23.300 μs** |     **400 B** |
| SortDescending | 100    |        28.544 μs |      1.6497 μs |      4.7859 μs |        27.650 μs |     400 B |
| **SortAscending**  | **1000**   |       **359.987 μs** |      **7.0885 μs** |     **14.1565 μs** |       **359.150 μs** |     **400 B** |
| SortDescending | 1000   |       316.008 μs |      5.8319 μs |      4.8699 μs |       315.400 μs |     400 B |
| **SortAscending**  | **10000**  |    **26,630.138 μs** |    **526.5781 μs** |    **850.3256 μs** |    **26,568.400 μs** |     **400 B** |
| SortDescending | 10000  |    25,214.490 μs |    499.0887 μs |    973.4343 μs |    25,248.650 μs |     400 B |
| **SortAscending**  | **100000** | **2,609,314.079 μs** | **12,995.6444 μs** | **11,520.3003 μs** | **2,609,035.100 μs** |     **400 B** |
| SortDescending | 100000 | 2,553,404.313 μs | 25,451.5924 μs | 23,807.4354 μs | 2,540,669.600 μs |     400 B |
