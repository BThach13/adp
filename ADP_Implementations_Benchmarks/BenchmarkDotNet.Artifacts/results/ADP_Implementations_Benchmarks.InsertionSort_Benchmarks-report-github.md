```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-GPDVOQ : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method         | N      | Mean             | Error         | StdDev        | Median           | Allocated |
|--------------- |------- |-----------------:|--------------:|--------------:|-----------------:|----------:|
| **SortAscending**  | **10**     |         **1.458 μs** |     **0.0803 μs** |     **0.2356 μs** |         **1.400 μs** |     **400 B** |
| SortDescending | 10     |         1.080 μs |     0.0717 μs |     0.2080 μs |         1.100 μs |     400 B |
| **SortAscending**  | **100**    |        **21.115 μs** |     **0.8105 μs** |     **2.3125 μs** |        **20.300 μs** |     **400 B** |
| SortDescending | 100    |        20.277 μs |     0.8474 μs |     2.4450 μs |        19.250 μs |     400 B |
| **SortAscending**  | **1000**   |       **219.347 μs** |     **4.3258 μs** |     **7.4617 μs** |       **218.650 μs** |     **400 B** |
| SortDescending | 1000   |       205.373 μs |     4.0763 μs |     6.4655 μs |       203.900 μs |     400 B |
| **SortAscending**  | **10000**  |    **18,454.832 μs** |   **352.0964 μs** |   **780.2214 μs** |    **18,399.000 μs** |     **400 B** |
| SortDescending | 10000  |    18,434.908 μs |   363.6776 μs |   497.8061 μs |    18,474.700 μs |     400 B |
| **SortAscending**  | **100000** | **1,780,474.073 μs** | **7,291.0424 μs** | **6,820.0456 μs** | **1,781,488.100 μs** |     **400 B** |
| SortDescending | 100000 | 1,766,143.579 μs | 7,136.5530 μs | 6,326.3683 μs | 1,766,409.750 μs |     400 B |
