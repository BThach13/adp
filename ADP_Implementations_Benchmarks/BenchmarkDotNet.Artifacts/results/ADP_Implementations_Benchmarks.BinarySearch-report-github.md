```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-GPQOXK : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method                 | N      | Mean       | Error     | StdDev   | Median     | Allocated |
|----------------------- |------- |-----------:|----------:|---------:|-----------:|----------:|
| **SearchBenchmark**        | **10**     |   **350.5 ns** |  **35.18 ns** | **100.9 ns** |   **400.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 10     |   483.8 ns |  51.94 ns | 152.3 ns |   500.0 ns |     400 B |
| **SearchBenchmark**        | **100**    |   **290.8 ns** |  **52.58 ns** | **153.4 ns** |   **300.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 100    |   508.2 ns |  62.20 ns | 181.4 ns |   500.0 ns |     400 B |
| **SearchBenchmark**        | **1000**   |   **536.7 ns** |  **67.38 ns** | **196.6 ns** |   **500.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 1000   |   632.7 ns |  72.14 ns | 210.4 ns |   600.0 ns |     400 B |
| **SearchBenchmark**        | **10000**  |   **858.3 ns** |  **72.82 ns** | **210.1 ns** |   **900.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 10000  |   936.4 ns | 108.53 ns | 318.3 ns |   900.0 ns |     400 B |
| **SearchBenchmark**        | **100000** | **1,222.4 ns** | **100.94 ns** | **294.5 ns** | **1,200.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 100000 | 1,378.6 ns | 129.14 ns | 376.7 ns | 1,400.0 ns |     400 B |
