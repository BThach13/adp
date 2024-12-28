```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-KCDRWQ : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method         | N      | Mean             | Error          | StdDev         | Median           | Allocated |
|--------------- |------- |-----------------:|---------------:|---------------:|-----------------:|----------:|
| **SortAscending**  | **10**     |         **1.057 μs** |      **0.0711 μs** |      **0.2086 μs** |         **1.000 μs** |     **400 B** |
| SortDescending | 10     |         1.307 μs |      0.0844 μs |      0.2487 μs |         1.300 μs |     400 B |
| **SortAscending**  | **100**    |        **20.252 μs** |      **0.9542 μs** |      **2.7069 μs** |        **19.700 μs** |     **400 B** |
| SortDescending | 100    |        19.018 μs |      0.8269 μs |      2.3592 μs |        18.000 μs |     400 B |
| **SortAscending**  | **1000**   |       **210.634 μs** |      **6.0571 μs** |     **17.4760 μs** |       **203.850 μs** |     **400 B** |
| SortDescending | 1000   |       207.984 μs |      4.0868 μs |      6.3627 μs |       206.300 μs |     400 B |
| **SortAscending**  | **10000**  |    **17,406.814 μs** |    **342.7389 μs** |    **491.5459 μs** |    **17,505.700 μs** |     **400 B** |
| SortDescending | 10000  |    17,869.350 μs |    331.6851 μs |    535.6096 μs |    17,872.600 μs |     400 B |
| **SortAscending**  | **100000** | **1,757,989.053 μs** | **12,512.1139 μs** | **11,703.8391 μs** | **1,758,641.000 μs** |     **400 B** |
| SortDescending | 100000 | 1,747,946.475 μs | 11,259.8519 μs |  8,790.9518 μs | 1,747,521.500 μs |     400 B |
