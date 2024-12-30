```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-BOWCDI : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method         | N      | Mean             | Error          | StdDev          | Median           | Allocated |
|--------------- |------- |-----------------:|---------------:|----------------:|-----------------:|----------:|
| **SortAscending**  | **10**     |         **1.331 μs** |      **0.0586 μs** |       **0.1718 μs** |         **1.300 μs** |     **400 B** |
| SortDescending | 10     |         1.362 μs |      0.0737 μs |       0.2160 μs |         1.300 μs |     400 B |
| **SortAscending**  | **100**    |        **17.545 μs** |      **0.7675 μs** |       **2.1648 μs** |        **16.600 μs** |     **400 B** |
| SortDescending | 100    |        18.103 μs |      0.7411 μs |       2.1024 μs |        17.500 μs |     400 B |
| **SortAscending**  | **1000**   |       **200.444 μs** |      **3.9359 μs** |       **7.2955 μs** |       **200.600 μs** |     **400 B** |
| SortDescending | 1000   |       200.169 μs |      3.9994 μs |       6.5711 μs |       199.000 μs |     400 B |
| **SortAscending**  | **10000**  |    **17,137.204 μs** |    **341.1235 μs** |     **455.3901 μs** |    **17,336.500 μs** |     **400 B** |
| SortDescending | 10000  |    17,514.518 μs |    335.2614 μs |     411.7311 μs |    17,521.950 μs |     400 B |
| **SortAscending**  | **100000** | **1,805,402.600 μs** | **36,024.1462 μs** |  **50,500.8259 μs** | **1,792,706.200 μs** |     **400 B** |
| SortDescending | 100000 | 1,907,740.671 μs | 97,309.9963 μs | 276,052.2829 μs | 1,842,120.400 μs |     400 B |
