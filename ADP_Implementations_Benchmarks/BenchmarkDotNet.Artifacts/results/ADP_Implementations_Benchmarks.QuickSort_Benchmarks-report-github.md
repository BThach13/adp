```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-MIAKQS : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method         | N      | Mean         | Error       | StdDev      | Median       | Allocated |
|--------------- |------- |-------------:|------------:|------------:|-------------:|----------:|
| **SortAscending**  | **10**     |     **2.407 μs** |   **0.1417 μs** |   **0.4132 μs** |     **2.400 μs** |     **592 B** |
| SortDescending | 10     |     2.926 μs |   0.1528 μs |   0.4506 μs |     2.950 μs |     712 B |
| **SortAscending**  | **100**    |    **16.806 μs** |   **0.7678 μs** |   **2.2275 μs** |    **17.400 μs** |    **3136 B** |
| SortDescending | 100    |    17.297 μs |   0.7490 μs |   2.1848 μs |    17.150 μs |    2656 B |
| **SortAscending**  | **1000**   |   **158.093 μs** |   **7.5181 μs** |  **21.8114 μs** |   **149.500 μs** |   **24400 B** |
| SortDescending | 1000   |   158.818 μs |   5.2491 μs |  14.6323 μs |   153.350 μs |   24784 B |
| **SortAscending**  | **10000**  | **1,343.950 μs** |  **26.2494 μs** |  **35.9305 μs** | **1,346.400 μs** |  **241600 B** |
| SortDescending | 10000  | 1,429.931 μs | 115.8030 μs | 330.3926 μs | 1,487.350 μs |  245728 B |
| **SortAscending**  | **100000** | **7,765.564 μs** | **307.0063 μs** | **865.9168 μs** | **7,413.200 μs** | **2421208 B** |
| SortDescending | 100000 | 7,816.876 μs | 164.1187 μs | 457.4973 μs | 7,670.050 μs | 2414248 B |
