```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-QXMLUZ : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method        | N     | Mean       | Error     | StdDev    | Median     | Allocated |
|-------------- |------ |-----------:|----------:|----------:|-----------:|----------:|
| **AddBenchmark**  | **10**    | **2,148.5 ns** | **141.62 ns** | **415.36 ns** | **2,100.0 ns** |     **440 B** |
| PeekBenchmark | 10    |   125.0 ns |  35.55 ns | 104.81 ns |   100.0 ns |     400 B |
| PollBenchmark | 10    |   156.4 ns |  30.65 ns |  87.45 ns |   200.0 ns |     400 B |
| **AddBenchmark**  | **100**   | **3,991.9 ns** | **178.29 ns** | **522.88 ns** | **4,000.0 ns** |     **440 B** |
| PeekBenchmark | 100   |   118.0 ns |  32.11 ns |  94.69 ns |   100.0 ns |     112 B |
| PollBenchmark | 100   |   243.0 ns |  35.51 ns | 104.69 ns |   300.0 ns |     400 B |
| **AddBenchmark**  | **1000**  | **1,806.6 ns** | **209.15 ns** | **586.48 ns** | **1,700.0 ns** |     **440 B** |
| PeekBenchmark | 1000  |   262.8 ns |  71.40 ns | 203.72 ns |   200.0 ns |     400 B |
| PollBenchmark | 1000  |   409.8 ns |  91.69 ns | 266.01 ns |   350.0 ns |     400 B |
| **AddBenchmark**  | **10000** | **2,006.2 ns** | **179.13 ns** | **516.84 ns** | **1,950.0 ns** |     **440 B** |
| PeekBenchmark | 10000 |   699.0 ns | 258.51 ns | 745.87 ns |   750.0 ns |     400 B |
| PollBenchmark | 10000 |   945.8 ns | 254.59 ns | 730.48 ns |   950.0 ns |     400 B |
