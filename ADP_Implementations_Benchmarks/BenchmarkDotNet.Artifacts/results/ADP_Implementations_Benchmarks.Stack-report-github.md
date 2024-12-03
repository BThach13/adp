```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-YOTSZK : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method        | N     | Mean      | Error    | StdDev   | Median    | Allocated |
|-------------- |------ |----------:|---------:|---------:|----------:|----------:|
| **PushBenchmark** | **10**    |  **78.79 ns** | **21.93 ns** | **64.32 ns** | **100.00 ns** |     **400 B** |
| PopBenchmark  | 10    |  85.86 ns | 24.84 ns | 72.86 ns | 100.00 ns |     400 B |
| PeekBenchmark | 10    |  77.38 ns | 15.67 ns | 42.09 ns | 100.00 ns |     400 B |
| **PushBenchmark** | **100**   |  **85.71 ns** | **23.09 ns** | **67.35 ns** | **100.00 ns** |     **400 B** |
| PopBenchmark  | 100   | 111.58 ns | 25.35 ns | 72.73 ns | 100.00 ns |     400 B |
| PeekBenchmark | 100   |  79.59 ns | 22.54 ns | 65.74 ns | 100.00 ns |     400 B |
| **PushBenchmark** | **1000**  | **134.34 ns** | **27.19 ns** | **79.75 ns** | **100.00 ns** |     **400 B** |
| PopBenchmark  | 1000  | 152.04 ns | 24.23 ns | 70.68 ns | 100.00 ns |     400 B |
| PeekBenchmark | 1000  |  69.23 ns | 18.00 ns | 46.45 ns | 100.00 ns |     400 B |
| **PushBenchmark** | **10000** |  **79.38 ns** | **19.23 ns** | **55.79 ns** | **100.00 ns** |     **400 B** |
| PopBenchmark  | 10000 | 173.74 ns | 23.15 ns | 67.89 ns | 200.00 ns |     400 B |
| PeekBenchmark | 10000 |  72.73 ns | 22.09 ns | 64.79 ns |  50.00 ns |     400 B |
