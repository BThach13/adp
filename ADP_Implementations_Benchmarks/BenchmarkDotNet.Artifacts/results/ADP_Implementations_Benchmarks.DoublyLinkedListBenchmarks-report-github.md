```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-OPWIMF : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method            | N      | Mean       | Error     | StdDev     | Allocated |
|------------------ |------- |-----------:|----------:|-----------:|----------:|
| **AddFirstBenchmark** | **10**     |   **888.8 ns** |  **68.01 ns** |   **198.4 ns** |     **440 B** |
| **AddFirstBenchmark** | **100**    |   **817.5 ns** |  **63.91 ns** |   **185.4 ns** |     **440 B** |
| **AddFirstBenchmark** | **1000**   |   **946.9 ns** |  **83.84 ns** |   **241.9 ns** |     **440 B** |
| **AddFirstBenchmark** | **10000**  |   **979.5 ns** |  **48.87 ns** |   **130.4 ns** |     **440 B** |
| **AddFirstBenchmark** | **100000** | **3,349.0 ns** | **453.55 ns** | **1,323.0 ns** |     **440 B** |
