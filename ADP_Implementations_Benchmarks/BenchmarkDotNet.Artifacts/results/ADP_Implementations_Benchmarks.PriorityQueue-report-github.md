```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-JSKMFH : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method        | N     | Mean        | Error     | StdDev    | Median        | Allocated |
|-------------- |------ |------------:|----------:|----------:|--------------:|----------:|
| **AddBenchmark**  | **10**    | **1,081.72 ns** |  **72.75 ns** | **206.39 ns** | **1,100.0000 ns** |     **440 B** |
| PeekBenchmark | 10    |    88.30 ns |  24.03 ns |  68.56 ns |   100.0000 ns |     400 B |
| PollBenchmark | 10    |   192.00 ns |  38.77 ns | 114.31 ns |   200.0000 ns |     400 B |
| **AddBenchmark**  | **100**   | **1,757.22 ns** |  **86.92 ns** | **252.18 ns** | **1,750.0000 ns** |     **152 B** |
| PeekBenchmark | 100   |    38.00 ns |  17.89 ns |  52.76 ns |     0.0000 ns |     400 B |
| PollBenchmark | 100   |   165.62 ns |  29.25 ns |  84.39 ns |   200.0000 ns |     400 B |
| **AddBenchmark**  | **1000**  | **1,640.40 ns** | **290.79 ns** | **852.84 ns** | **1,500.0000 ns** |     **440 B** |
| PeekBenchmark | 1000  |   254.35 ns |  56.71 ns | 159.95 ns |   200.0000 ns |     400 B |
| PollBenchmark | 1000  |   342.11 ns |  63.82 ns | 183.10 ns |   300.0000 ns |     400 B |
| **AddBenchmark**  | **10000** | **2,600.00 ns** | **287.61 ns** | **834.42 ns** | **2,600.0000 ns** |     **440 B** |
| PeekBenchmark | 10000 |   897.42 ns | 240.36 ns | 697.33 ns |   950.0000 ns |      64 B |
| PollBenchmark | 10000 | 1,136.84 ns | 265.48 ns | 761.72 ns | 1,200.0000 ns |     400 B |
