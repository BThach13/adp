```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-ABLFMZ : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method            | N      | Mean     | Error    | StdDev   | Median   | Allocated |
|------------------ |------- |---------:|---------:|---------:|---------:|----------:|
| **AddFirstBenchmark** | **10**     | **859.2 ns** | **73.65 ns** | **214.8 ns** | **900.0 ns** |     **440 B** |
| **AddFirstBenchmark** | **99**     | **779.6 ns** | **55.52 ns** | **162.0 ns** | **750.0 ns** |     **440 B** |
| **AddFirstBenchmark** | **100**    | **813.0 ns** | **75.09 ns** | **221.4 ns** | **900.0 ns** |     **440 B** |
| **AddFirstBenchmark** | **1000**   | **942.8 ns** | **69.16 ns** | **200.6 ns** | **950.0 ns** |     **440 B** |
| **AddFirstBenchmark** | **10000**  | **838.0 ns** | **65.70 ns** | **193.7 ns** | **800.0 ns** |     **440 B** |
| **AddFirstBenchmark** | **100000** | **706.5 ns** | **58.30 ns** | **165.4 ns** | **700.0 ns** |     **440 B** |
