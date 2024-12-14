```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-EZBQGO : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method                 | N      | Mean       | Error     | StdDev    | Median     | Allocated |
|----------------------- |------- |-----------:|----------:|----------:|-----------:|----------:|
| **SearchBenchmark**        | **10**     |   **268.8 ns** |  **28.46 ns** |  **80.73 ns** |   **300.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 10     |   284.0 ns |  43.58 ns | 128.49 ns |   300.0 ns |     112 B |
| **SearchBenchmark**        | **100**    |   **240.6 ns** |  **48.78 ns** | **140.73 ns** |   **250.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 100    |   425.3 ns |  40.27 ns | 118.10 ns |   400.0 ns |     112 B |
| **SearchBenchmark**        | **1000**   |   **384.5 ns** |  **39.28 ns** | **113.96 ns** |   **400.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 1000   |   544.9 ns |  43.40 ns | 127.27 ns |   550.0 ns |     112 B |
| **SearchBenchmark**        | **10000**  |   **640.4 ns** |  **67.62 ns** | **192.92 ns** |   **650.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 10000  |   803.1 ns |  64.76 ns | 187.89 ns |   800.0 ns |     112 B |
| **SearchBenchmark**        | **100000** |   **989.8 ns** | **111.65 ns** | **325.70 ns** | **1,000.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 100000 | 1,267.7 ns | 137.58 ns | 403.51 ns | 1,300.0 ns |     112 B |
