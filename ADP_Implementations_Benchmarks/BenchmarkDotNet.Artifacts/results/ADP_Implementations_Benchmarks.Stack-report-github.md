```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-YNCUYQ : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method        | N     | Mean        | Error     | StdDev    | Median        | Allocated |
|-------------- |------ |------------:|----------:|----------:|--------------:|----------:|
| **PushBenchmark** | **10**    | **1,572.73 ns** | **139.98 ns** | **410.53 ns** | **1,600.0000 ns** |     **504 B** |
| PopBenchmark  | 10    |   125.26 ns |  33.32 ns |  95.61 ns |   100.0000 ns |     400 B |
| PeekBenchmark | 10    |   145.96 ns |  36.34 ns | 106.59 ns |   150.0000 ns |     400 B |
| **PushBenchmark** | **100**   |    **62.37 ns** |  **25.94 ns** |  **73.59 ns** |     **0.0000 ns** |     **400 B** |
| PopBenchmark  | 100   |    56.12 ns |  28.73 ns |  83.81 ns |     0.0000 ns |     400 B |
| PeekBenchmark | 100   |   177.78 ns |  37.59 ns | 110.25 ns |   200.0000 ns |     400 B |
| **PushBenchmark** | **1000**  |    **63.83 ns** |  **23.47 ns** |  **66.96 ns** |   **100.0000 ns** |     **400 B** |
| PopBenchmark  | 1000  |   146.39 ns |  29.04 ns |  84.24 ns |   200.0000 ns |     400 B |
| PeekBenchmark | 1000  |   137.37 ns |  41.78 ns | 122.55 ns |   100.0000 ns |     400 B |
| **PushBenchmark** | **10000** |    **64.58 ns** |  **25.63 ns** |  **73.95 ns** |     **0.0000 ns** |     **400 B** |
| PopBenchmark  | 10000 |   137.23 ns |  34.86 ns |  99.44 ns |   100.0000 ns |     400 B |
| PeekBenchmark | 10000 |   148.94 ns |  31.58 ns |  90.10 ns |   100.0000 ns |     112 B |
