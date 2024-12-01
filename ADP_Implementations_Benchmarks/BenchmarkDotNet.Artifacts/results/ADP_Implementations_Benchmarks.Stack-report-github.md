```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-VYVBVW : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method        | N     | Mean        | Error     | StdDev     | Median     | Allocated |
|-------------- |------ |------------:|----------:|-----------:|-----------:|----------:|
| **PushBenchmark** | **10**    | **1,286.87 ns** | **80.430 ns** | **235.886 ns** | **1,300.0 ns** |     **504 B** |
| PopBenchmark  | 10    |   160.00 ns | 22.610 ns |  66.667 ns |   200.0 ns |     400 B |
| PeekBenchmark | 10    |   135.71 ns | 27.074 ns |  78.975 ns |   100.0 ns |     400 B |
| **PushBenchmark** | **100**   |   **100.00 ns** |  **0.000 ns** |   **0.000 ns** |   **100.0 ns** |     **400 B** |
| PopBenchmark  | 100   |    84.69 ns | 25.269 ns |  73.712 ns |   100.0 ns |     400 B |
| PeekBenchmark | 100   |    79.22 ns | 15.932 ns |  40.839 ns |   100.0 ns |     400 B |
| **PushBenchmark** | **1000**  |    **73.08 ns** | **17.295 ns** |  **44.643 ns** |   **100.0 ns** |     **112 B** |
| PopBenchmark  | 1000  |   119.19 ns | 26.084 ns |  76.501 ns |   100.0 ns |     400 B |
| PeekBenchmark | 1000  |   121.00 ns | 26.533 ns |  78.232 ns |   100.0 ns |     400 B |
| **PushBenchmark** | **10000** |    **64.95 ns** | **22.272 ns** |  **64.616 ns** |   **100.0 ns** |     **400 B** |
| PopBenchmark  | 10000 |   186.17 ns | 24.436 ns |  69.717 ns |   200.0 ns |     400 B |
| PeekBenchmark | 10000 |    91.92 ns | 22.678 ns |  66.512 ns |   100.0 ns |     400 B |
