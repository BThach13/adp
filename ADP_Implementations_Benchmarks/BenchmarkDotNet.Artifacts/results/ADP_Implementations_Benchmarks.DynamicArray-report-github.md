```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-QUSBDE : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method            | N      | Mean         | Error        | StdDev       | Median       | Allocated |
|------------------ |------- |-------------:|-------------:|-------------:|-------------:|----------:|
| **AddBenchmark**      | **10**     |     **217.2 ns** |     **25.33 ns** |     **74.29 ns** |     **200.0 ns** |     **400 B** |
| SetBenchmark      | 10     |     751.0 ns |     44.37 ns |    129.43 ns |     700.0 ns |     400 B |
| IndexOfBenchmark  | 10     |     577.6 ns |     50.33 ns |    146.81 ns |     600.0 ns |     400 B |
| ContainsBenchmark | 10     |     636.4 ns |     50.96 ns |    149.46 ns |     600.0 ns |     400 B |
| RemoveBenchmark   | 10     |   1,345.1 ns |     66.67 ns |    186.94 ns |   1,300.0 ns |     552 B |
| RemoveAtBenchmark | 10     |   1,404.1 ns |    103.01 ns |    300.49 ns |   1,400.0 ns |     552 B |
| **AddBenchmark**      | **99**     |   **3,370.1 ns** |    **144.55 ns** |    **419.37 ns** |   **3,300.0 ns** |    **1696 B** |
| SetBenchmark      | 99     |   4,191.8 ns |    211.29 ns |    613.00 ns |   4,300.0 ns |     400 B |
| IndexOfBenchmark  | 99     |   3,463.0 ns |    170.94 ns |    482.15 ns |   3,600.0 ns |     400 B |
| ContainsBenchmark | 99     |   2,629.9 ns |    199.82 ns |    579.72 ns |   2,400.0 ns |     400 B |
| RemoveBenchmark   | 99     |   2,801.0 ns |    174.91 ns |    512.99 ns |   2,600.0 ns |     552 B |
| RemoveAtBenchmark | 99     |   3,796.9 ns |    294.26 ns |    858.37 ns |   3,500.0 ns |     552 B |
| **AddBenchmark**      | **100**    |   **3,340.0 ns** |    **139.79 ns** |    **412.19 ns** |   **3,300.0 ns** |    **1696 B** |
| SetBenchmark      | 100    |   3,518.4 ns |    194.20 ns |    566.48 ns |   3,500.0 ns |     400 B |
| IndexOfBenchmark  | 100    |   2,806.0 ns |    244.27 ns |    720.24 ns |   2,500.0 ns |     400 B |
| ContainsBenchmark | 100    |   2,889.0 ns |    230.22 ns |    678.81 ns |   2,900.0 ns |     400 B |
| RemoveBenchmark   | 100    |   2,868.0 ns |    173.39 ns |    503.02 ns |   2,700.0 ns |     552 B |
| RemoveAtBenchmark | 100    |   3,786.7 ns |    259.81 ns |    757.86 ns |   3,450.0 ns |     552 B |
| **AddBenchmark**      | **1000**   |  **17,701.0 ns** |  **1,239.56 ns** |  **3,576.43 ns** |  **16,250.0 ns** |   **10728 B** |
| SetBenchmark      | 1000   |  31,967.0 ns |  1,127.35 ns |  3,216.40 ns |  30,750.0 ns |     400 B |
| IndexOfBenchmark  | 1000   |  25,232.2 ns |  1,185.82 ns |  3,305.59 ns |  24,400.0 ns |     400 B |
| ContainsBenchmark | 1000   |  25,021.2 ns |  1,254.34 ns |  3,678.77 ns |  23,300.0 ns |     400 B |
| RemoveBenchmark   | 1000   |  14,154.6 ns |    948.79 ns |  2,752.61 ns |  13,100.0 ns |     552 B |
| RemoveAtBenchmark | 1000   |  27,006.2 ns |  1,255.42 ns |  3,642.20 ns |  25,300.0 ns |     552 B |
| **AddBenchmark**      | **10000**  |  **30,479.8 ns** |  **1,545.53 ns** |  **4,532.76 ns** |  **28,900.0 ns** |   **82480 B** |
| SetBenchmark      | 10000  |  68,077.9 ns |  1,294.55 ns |  3,101.65 ns |  67,350.0 ns |     400 B |
| IndexOfBenchmark  | 10000  |  42,985.1 ns |    861.76 ns |  2,161.98 ns |  42,300.0 ns |     400 B |
| ContainsBenchmark | 10000  |  42,591.6 ns |  1,115.04 ns |  3,199.26 ns |  41,400.0 ns |     400 B |
| RemoveBenchmark   | 10000  |  24,235.0 ns |  1,432.78 ns |  4,224.59 ns |  22,200.0 ns |     552 B |
| RemoveAtBenchmark | 10000  |  45,495.2 ns |    862.99 ns |  1,965.47 ns |  45,150.0 ns |     552 B |
| **AddBenchmark**      | **100000** | **321,957.0 ns** | **19,094.86 ns** | **54,168.96 ns** | **297,500.0 ns** | **1311376 B** |
| SetBenchmark      | 100000 | 457,262.1 ns |  8,955.10 ns | 13,126.27 ns | 459,300.0 ns |     400 B |
| IndexOfBenchmark  | 100000 | 232,868.8 ns |  4,250.26 ns |  4,174.32 ns | 233,300.0 ns |     400 B |
| ContainsBenchmark | 100000 | 243,450.0 ns |  4,829.98 ns |  5,168.03 ns | 241,550.0 ns |     400 B |
| RemoveBenchmark   | 100000 |  95,667.4 ns |  1,902.81 ns |  3,666.06 ns |  94,250.0 ns |     552 B |
| RemoveAtBenchmark | 100000 | 262,682.6 ns |  5,231.64 ns | 10,079.60 ns | 260,750.0 ns |     552 B |
