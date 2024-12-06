```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-GYTVLR : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method               | N      | Mean       | Error     | StdDev      | Median     | Allocated |
|--------------------- |------- |-----------:|----------:|------------:|-----------:|----------:|
| **InsertRightBenchmark** | **10**     |   **959.2 ns** |  **65.64 ns** |   **191.49 ns** | **1,000.0 ns** |     **440 B** |
| AddLeftBenchmark     | 10     |   885.3 ns |  64.10 ns |   183.91 ns |   900.0 ns |     440 B |
| DeleteRightBenchmark | 10     |   125.8 ns |  29.55 ns |    85.73 ns |   100.0 ns |     400 B |
| DeleteLeftBenchmark  | 10     |   170.8 ns |  27.51 ns |    79.36 ns |   200.0 ns |     400 B |
| **InsertRightBenchmark** | **100**    |   **842.1 ns** |  **63.41 ns** |   **181.94 ns** |   **800.0 ns** |     **440 B** |
| AddLeftBenchmark     | 100    |   935.0 ns |  59.31 ns |   174.87 ns |   900.0 ns |     440 B |
| DeleteRightBenchmark | 100    |   165.4 ns |  21.77 ns |    57.36 ns |   200.0 ns |     400 B |
| DeleteLeftBenchmark  | 100    |   190.9 ns |  25.82 ns |    75.72 ns |   200.0 ns |     400 B |
| **InsertRightBenchmark** | **1000**   |   **984.5 ns** |  **58.52 ns** |   **169.77 ns** | **1,000.0 ns** |     **440 B** |
| AddLeftBenchmark     | 1000   |   948.5 ns |  49.04 ns |   143.83 ns | 1,000.0 ns |     440 B |
| DeleteRightBenchmark | 1000   |   167.1 ns |  19.66 ns |    50.04 ns |   200.0 ns |     400 B |
| DeleteLeftBenchmark  | 1000   |   185.9 ns |  24.84 ns |    72.86 ns |   200.0 ns |     400 B |
| **InsertRightBenchmark** | **10000**  | **1,283.3 ns** |  **66.35 ns** |   **178.23 ns** | **1,300.0 ns** |     **440 B** |
| AddLeftBenchmark     | 10000  | 1,901.1 ns | 163.66 ns |   461.60 ns | 1,800.0 ns |     152 B |
| DeleteRightBenchmark | 10000  |   175.3 ns |  16.93 ns |    43.39 ns |   200.0 ns |     400 B |
| DeleteLeftBenchmark  | 10000  |   244.1 ns |  24.08 ns |    68.31 ns |   200.0 ns |     400 B |
| **InsertRightBenchmark** | **100000** | **4,496.0 ns** | **756.16 ns** | **2,229.55 ns** | **4,050.0 ns** |     **440 B** |
| AddLeftBenchmark     | 100000 | 3,092.5 ns | 353.43 ns | 1,002.63 ns | 2,800.0 ns |     440 B |
| DeleteRightBenchmark | 100000 | 1,300.0 ns | 173.60 ns |   498.08 ns | 1,300.0 ns |     400 B |
| DeleteLeftBenchmark  | 100000 | 1,217.7 ns | 148.93 ns |   429.69 ns | 1,150.0 ns |     400 B |
