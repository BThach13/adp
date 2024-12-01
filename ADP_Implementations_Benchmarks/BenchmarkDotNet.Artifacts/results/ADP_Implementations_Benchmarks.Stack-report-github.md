```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-RDHPIK : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method        | N     | Mean        | Error     | StdDev    | Median        | Allocated |
|-------------- |------ |------------:|----------:|----------:|--------------:|----------:|
| **PushBenchmark** | **10**    | **1,500.00 ns** | **108.85 ns** | **317.53 ns** | **1,500.0000 ns** |     **504 B** |
| PopBenchmark  | 10    |    67.03 ns |  26.07 ns |  73.11 ns |   100.0000 ns |     400 B |
| PeekBenchmark | 10    |   120.83 ns |  29.72 ns |  85.74 ns |   100.0000 ns |     400 B |
| **PushBenchmark** | **100**   |    **66.67 ns** |  **33.39 ns** |  **97.94 ns** |     **0.0000 ns** |     **400 B** |
| PopBenchmark  | 100   |   137.00 ns |  38.76 ns | 114.29 ns |   100.0000 ns |     400 B |
| PeekBenchmark | 100   |   111.00 ns |  30.06 ns |  88.64 ns |   100.0000 ns |     400 B |
| **PushBenchmark** | **1000**  |   **121.00 ns** |  **35.19 ns** | **103.76 ns** |   **100.0000 ns** |     **400 B** |
| PopBenchmark  | 1000  |   158.51 ns |  31.86 ns |  90.89 ns |   200.0000 ns |     400 B |
| PeekBenchmark | 1000  |   158.33 ns |  32.07 ns |  92.53 ns |   100.0000 ns |     400 B |
| **PushBenchmark** | **10000** |    **60.42 ns** |  **25.38 ns** |  **73.24 ns** |     **0.0000 ns** |     **400 B** |
| PopBenchmark  | 10000 |   187.37 ns |  34.39 ns | 100.85 ns |   150.0000 ns |     400 B |
| PeekBenchmark | 10000 |   112.12 ns |  36.54 ns | 107.16 ns |   100.0000 ns |     400 B |
