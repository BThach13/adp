```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-ICJEUZ : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method         | N      | Mean             | Error          | StdDev         | Median           | Allocated |
|--------------- |------- |-----------------:|---------------:|---------------:|-----------------:|----------:|
| **SortAscending**  | **10**     |         **1.106 μs** |      **0.0718 μs** |      **0.2117 μs** |         **1.100 μs** |     **400 B** |
| SortDescending | 10     |         1.133 μs |      0.0723 μs |      0.2132 μs |         1.100 μs |     400 B |
| **SortAscending**  | **100**    |        **21.067 μs** |      **1.0715 μs** |      **3.0572 μs** |        **20.350 μs** |      **64 B** |
| SortDescending | 100    |        18.258 μs |      0.7114 μs |      2.0411 μs |        17.500 μs |     400 B |
| **SortAscending**  | **1000**   |       **212.198 μs** |      **4.2134 μs** |      **8.5112 μs** |       **210.500 μs** |     **400 B** |
| SortDescending | 1000   |       206.457 μs |      4.1263 μs |      8.2406 μs |       205.900 μs |     400 B |
| **SortAscending**  | **10000**  |    **17,870.237 μs** |    **352.0914 μs** |    **652.6241 μs** |    **17,931.900 μs** |     **400 B** |
| SortDescending | 10000  |    17,878.980 μs |    340.4573 μs |    647.7555 μs |    17,859.700 μs |     400 B |
| **SortAscending**  | **100000** | **1,760,499.993 μs** | **10,764.9885 μs** |  **9,542.8819 μs** | **1,759,105.300 μs** |     **400 B** |
| SortDescending | 100000 | 1,753,830.586 μs | 24,709.6582 μs | 21,904.4684 μs | 1,747,588.750 μs |     400 B |
