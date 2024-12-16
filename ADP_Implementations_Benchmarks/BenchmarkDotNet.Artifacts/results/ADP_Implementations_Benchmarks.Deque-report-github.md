```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-AIBWUL : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method               | N      | Mean        | Error     | StdDev      | Median        | Allocated |
|--------------------- |------- |------------:|----------:|------------:|--------------:|----------:|
| **InsertRightBenchmark** | **10**     | **1,097.96 ns** |  **59.47 ns** |   **173.49 ns** | **1,100.0000 ns** |     **440 B** |
| InsertLeftBenchmark  | 10     |   930.53 ns |  59.30 ns |   170.15 ns |   900.0000 ns |     440 B |
| DeleteRightBenchmark | 10     |   142.86 ns |  27.85 ns |    81.23 ns |   100.0000 ns |     400 B |
| DeleteLeftBenchmark  | 10     |   173.03 ns |  16.11 ns |    44.63 ns |   200.0000 ns |     400 B |
| **InsertRightBenchmark** | **100**    |   **917.35 ns** |  **62.66 ns** |   **182.78 ns** |   **900.0000 ns** |     **440 B** |
| InsertLeftBenchmark  | 100    |   943.88 ns |  69.63 ns |   203.10 ns |   900.0000 ns |     440 B |
| DeleteRightBenchmark | 100    |   237.37 ns |  26.49 ns |    77.70 ns |   200.0000 ns |     400 B |
| DeleteLeftBenchmark  | 100    |    59.18 ns |  25.50 ns |    74.39 ns |     0.0000 ns |     400 B |
| **InsertRightBenchmark** | **1000**   | **1,045.36 ns** |  **72.78 ns** |   **211.16 ns** | **1,000.0000 ns** |     **440 B** |
| InsertLeftBenchmark  | 1000   | 1,161.05 ns |  73.72 ns |   211.53 ns | 1,100.0000 ns |     440 B |
| DeleteRightBenchmark | 1000   |   179.01 ns |  15.55 ns |    40.98 ns |   200.0000 ns |     400 B |
| DeleteLeftBenchmark  | 1000   |   189.90 ns |  26.00 ns |    76.26 ns |   200.0000 ns |     400 B |
| **InsertRightBenchmark** | **10000**  | **1,831.58 ns** | **165.54 ns** |   **474.96 ns** | **1,800.0000 ns** |     **440 B** |
| InsertLeftBenchmark  | 10000  | 2,256.00 ns | 578.43 ns | 1,705.51 ns | 1,200.0000 ns |     440 B |
| DeleteRightBenchmark | 10000  |   176.00 ns |  23.67 ns |    69.80 ns |   200.0000 ns |     400 B |
| DeleteLeftBenchmark  | 10000  |   176.83 ns |  16.01 ns |    42.45 ns |   200.0000 ns |     400 B |
| **InsertRightBenchmark** | **100000** | **3,887.37 ns** | **533.59 ns** | **1,530.97 ns** | **3,500.0000 ns** |     **440 B** |
| InsertLeftBenchmark  | 100000 | 3,669.79 ns | 432.63 ns | 1,248.25 ns | 3,300.0000 ns |     440 B |
| DeleteRightBenchmark | 100000 | 1,344.68 ns | 166.52 ns |   475.10 ns | 1,300.0000 ns |     400 B |
| DeleteLeftBenchmark  | 100000 | 1,319.59 ns | 172.46 ns |   500.34 ns | 1,200.0000 ns |     400 B |
