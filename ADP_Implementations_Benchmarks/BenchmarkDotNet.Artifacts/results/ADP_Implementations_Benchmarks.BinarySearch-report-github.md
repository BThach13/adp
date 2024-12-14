```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-YBANOL : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method                 | N      | Mean     | Error    | StdDev    | Median   | Allocated |
|----------------------- |------- |---------:|---------:|----------:|---------:|----------:|
| **SearchBenchmark**        | **10**     | **180.6 ns** | **24.44 ns** |  **71.30 ns** | **200.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 10     | 223.2 ns | 26.15 ns |  76.70 ns | 200.0 ns |     400 B |
| **SearchBenchmark**        | **100**    | **151.0 ns** | **25.22 ns** |  **73.56 ns** | **100.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 100    | 251.5 ns | 26.84 ns |  77.88 ns | 300.0 ns |     400 B |
| **SearchBenchmark**        | **1000**   | **245.7 ns** | **31.72 ns** |  **89.46 ns** | **200.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 1000   | 440.4 ns | 34.60 ns |  98.72 ns | 500.0 ns |     400 B |
| **SearchBenchmark**        | **10000**  | **394.0 ns** | **48.40 ns** | **142.72 ns** | **400.0 ns** |      **64 B** |
| SearchBenchmarkDoWhile | 10000  | 430.4 ns | 37.44 ns | 105.60 ns | 400.0 ns |      64 B |
| **SearchBenchmark**        | **100000** | **550.5 ns** | **61.49 ns** | **180.35 ns** | **500.0 ns** |     **400 B** |
| SearchBenchmarkDoWhile | 100000 | 610.4 ns | 48.36 ns | 139.53 ns | 600.0 ns |     400 B |
