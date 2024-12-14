```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-OVKHUD : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method                 | N      | Mean       | Error     | StdDev    | Median     | Allocated |
|----------------------- |------- |-----------:|----------:|----------:|-----------:|----------:|
| **SearchBenchmark**        | **10**     |   **226.3 ns** |  **32.64 ns** |  **93.64 ns** |   **200.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 10     |   263.8 ns |  29.01 ns |  82.76 ns |   300.0 ns |     400 B |
| **SearchBenchmark**        | **100**    |   **252.1 ns** |  **27.55 ns** |  **78.60 ns** |   **300.0 ns** |     **112 B** |
| SearchBenchmarkDoWhile | 100    |   421.4 ns |  35.58 ns | 103.79 ns |   400.0 ns |     400 B |
| **SearchBenchmark**        | **1000**   |   **368.2 ns** |  **32.81 ns** |  **96.22 ns** |   **350.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 1000   |   474.0 ns |  43.28 ns | 127.62 ns |   500.0 ns |     400 B |
| **SearchBenchmark**        | **10000**  |   **437.4 ns** |  **35.52 ns** |  **99.61 ns** |   **400.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 10000  |   664.3 ns |  73.38 ns | 214.07 ns |   600.0 ns |     400 B |
| **SearchBenchmark**        | **100000** |   **769.1 ns** |  **61.90 ns** | **176.60 ns** |   **800.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 100000 | 1,243.8 ns | 119.62 ns | 345.14 ns | 1,250.0 ns |     400 B |
