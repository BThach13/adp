```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-DUULBT : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method          | N      | Mean     | Error    | StdDev    | Median   | Allocated |
|---------------- |------- |---------:|---------:|----------:|---------:|----------:|
| **SearchBenchmark** | **10**     | **151.0 ns** | **22.15 ns** |  **64.61 ns** | **200.0 ns** |     **400 B** |
| **SearchBenchmark** | **100**    | **177.9 ns** | **16.29 ns** |  **41.75 ns** | **200.0 ns** |     **400 B** |
| **SearchBenchmark** | **1000**   | **333.0 ns** | **47.91 ns** | **138.99 ns** | **300.0 ns** |     **400 B** |
| **SearchBenchmark** | **10000**  | **580.8 ns** | **56.32 ns** | **165.17 ns** | **600.0 ns** |     **400 B** |
| **SearchBenchmark** | **100000** | **606.7 ns** | **65.99 ns** | **191.43 ns** | **550.0 ns** |      **64 B** |
