```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-BWDIFE : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method               | N      | Mean          | Error        | StdDev        | Median       | Allocated |
|--------------------- |------- |--------------:|-------------:|--------------:|-------------:|----------:|
| **AddFirstBenchmark**    | **10**     |     **976.29 ns** |     **72.23 ns** |     **209.55 ns** |   **1,000.0 ns** |     **440 B** |
| AddLastBenchmark     | 10     |     971.13 ns |     72.77 ns |     211.13 ns |   1,000.0 ns |     440 B |
| SetBenchmark         | 10     |   1,245.36 ns |     74.13 ns |     215.07 ns |   1,200.0 ns |     440 B |
| RemoveFirstBenchmark | 10     |     178.35 ns |     25.96 ns |      75.31 ns |     200.0 ns |     400 B |
| RemoveLastBenchmark  | 10     |     126.80 ns |     30.06 ns |      87.22 ns |     100.0 ns |     400 B |
| RemoveAtBenchmark    | 10     |     500.00 ns |     45.43 ns |     133.25 ns |     500.0 ns |     400 B |
| GetFirstBenchmark    | 10     |     101.00 ns |     28.31 ns |      83.48 ns |     100.0 ns |     400 B |
| GetLastBenchmark     | 10     |     107.00 ns |     23.74 ns |      70.00 ns |     100.0 ns |     400 B |
| GetBenchmark         | 10     |     277.55 ns |     33.94 ns |      99.00 ns |     300.0 ns |     400 B |
| ContainsBenchmark    | 10     |     624.49 ns |     36.53 ns |     106.55 ns |     600.0 ns |     400 B |
| **AddFirstBenchmark**    | **99**     |     **942.27 ns** |     **65.03 ns** |     **188.65 ns** |     **900.0 ns** |     **440 B** |
| AddLastBenchmark     | 99     |     911.00 ns |     64.83 ns |     191.17 ns |     900.0 ns |     440 B |
| SetBenchmark         | 99     |   2,289.69 ns |    105.71 ns |     306.69 ns |   2,300.0 ns |     440 B |
| RemoveFirstBenchmark | 99     |     198.99 ns |     28.19 ns |      82.68 ns |     200.0 ns |     400 B |
| RemoveLastBenchmark  | 99     |     187.63 ns |     24.50 ns |      71.09 ns |     200.0 ns |     400 B |
| RemoveAtBenchmark    | 99     |   1,310.00 ns |     60.21 ns |     177.53 ns |   1,250.0 ns |     400 B |
| GetFirstBenchmark    | 99     |      72.15 ns |     17.36 ns |      45.11 ns |     100.0 ns |     400 B |
| GetLastBenchmark     | 99     |     110.10 ns |     26.45 ns |      77.58 ns |     100.0 ns |     112 B |
| GetBenchmark         | 99     |     770.00 ns |    101.63 ns |     299.66 ns |     800.0 ns |     400 B |
| ContainsBenchmark    | 99     |   1,930.30 ns |    111.12 ns |     325.91 ns |   1,800.0 ns |     400 B |
| **AddFirstBenchmark**    | **100**    |     **974.00 ns** |     **57.77 ns** |     **170.34 ns** |   **1,000.0 ns** |     **440 B** |
| AddLastBenchmark     | 100    |   1,000.00 ns |     61.94 ns |     179.70 ns |   1,000.0 ns |     440 B |
| SetBenchmark         | 100    |   2,218.56 ns |     87.08 ns |     252.62 ns |   2,200.0 ns |     440 B |
| RemoveFirstBenchmark | 100    |     164.56 ns |     21.38 ns |      55.56 ns |     200.0 ns |     400 B |
| RemoveLastBenchmark  | 100    |     204.04 ns |     27.52 ns |      80.71 ns |     200.0 ns |     400 B |
| RemoveAtBenchmark    | 100    |   1,372.45 ns |     66.37 ns |     193.60 ns |   1,400.0 ns |     400 B |
| GetFirstBenchmark    | 100    |     104.00 ns |     28.08 ns |      82.78 ns |     100.0 ns |     400 B |
| GetLastBenchmark     | 100    |      74.68 ns |     16.84 ns |      43.76 ns |     100.0 ns |     400 B |
| GetBenchmark         | 100    |     839.39 ns |    108.68 ns |     318.74 ns |     800.0 ns |     400 B |
| ContainsBenchmark    | 100    |   2,015.00 ns |    125.92 ns |     371.29 ns |   1,900.0 ns |     400 B |
| **AddFirstBenchmark**    | **1000**   |     **919.39 ns** |     **77.78 ns** |     **226.88 ns** |     **900.0 ns** |     **440 B** |
| AddLastBenchmark     | 1000   |   1,053.16 ns |     75.14 ns |     215.59 ns |   1,050.0 ns |     104 B |
| SetBenchmark         | 1000   |   8,909.79 ns |    687.71 ns |   1,995.18 ns |   8,150.0 ns |     440 B |
| RemoveFirstBenchmark | 1000   |     209.28 ns |     26.36 ns |      76.49 ns |     200.0 ns |     400 B |
| RemoveLastBenchmark  | 1000   |     201.03 ns |     31.27 ns |      90.71 ns |     200.0 ns |     400 B |
| RemoveAtBenchmark    | 1000   |   9,995.88 ns |    950.67 ns |   2,758.05 ns |   9,800.0 ns |     400 B |
| GetFirstBenchmark    | 1000   |     112.12 ns |     26.35 ns |      77.29 ns |     100.0 ns |     400 B |
| GetLastBenchmark     | 1000   |     125.25 ns |     24.03 ns |      70.48 ns |     100.0 ns |     400 B |
| GetBenchmark         | 1000   |   4,445.45 ns |    918.85 ns |   2,694.83 ns |   4,600.0 ns |     112 B |
| ContainsBenchmark    | 1000   |  15,814.89 ns |    521.78 ns |   1,488.66 ns |  15,550.0 ns |     400 B |
| **AddFirstBenchmark**    | **10000**  |   **1,102.56 ns** |     **62.43 ns** |     **161.14 ns** |   **1,100.0 ns** |     **440 B** |
| AddLastBenchmark     | 10000  |   1,937.50 ns |    434.21 ns |   1,252.81 ns |   1,300.0 ns |     104 B |
| SetBenchmark         | 10000  |  24,983.67 ns |    864.51 ns |   2,521.81 ns |  24,400.0 ns |     440 B |
| RemoveFirstBenchmark | 10000  |     249.40 ns |     40.69 ns |     108.62 ns |     200.0 ns |     400 B |
| RemoveLastBenchmark  | 10000  |     306.19 ns |     37.83 ns |     109.75 ns |     300.0 ns |     400 B |
| RemoveAtBenchmark    | 10000  |  21,708.62 ns |    434.49 ns |     953.72 ns |  21,400.0 ns |     400 B |
| GetFirstBenchmark    | 10000  |     170.79 ns |     20.50 ns |      56.81 ns |     200.0 ns |     400 B |
| GetLastBenchmark     | 10000  |     210.00 ns |     21.54 ns |      60.06 ns |     200.0 ns |     400 B |
| GetBenchmark         | 10000  |  14,926.00 ns |  1,995.48 ns |   5,883.73 ns |  14,550.0 ns |     400 B |
| ContainsBenchmark    | 10000  |  31,723.96 ns |    634.99 ns |   1,832.10 ns |  31,250.0 ns |     400 B |
| **AddFirstBenchmark**    | **100000** |   **3,461.29 ns** |    **394.77 ns** |   **1,119.88 ns** |   **3,200.0 ns** |     **440 B** |
| AddLastBenchmark     | 100000 |   3,544.09 ns |    519.29 ns |   1,473.13 ns |   3,100.0 ns |     440 B |
| SetBenchmark         | 100000 | 191,691.76 ns | 11,247.10 ns |  30,407.20 ns | 182,400.0 ns |     440 B |
| RemoveFirstBenchmark | 100000 |   1,257.29 ns |    163.40 ns |     471.45 ns |   1,300.0 ns |     400 B |
| RemoveLastBenchmark  | 100000 |   1,510.00 ns |    193.00 ns |     538.01 ns |   1,400.0 ns |     400 B |
| RemoveAtBenchmark    | 100000 | 202,366.29 ns | 20,366.35 ns |  56,435.06 ns | 181,100.0 ns |     112 B |
| GetFirstBenchmark    | 100000 |   1,062.22 ns |    220.85 ns |     615.63 ns |     900.0 ns |     400 B |
| GetLastBenchmark     | 100000 |     881.91 ns |    142.07 ns |     405.33 ns |     900.0 ns |     400 B |
| GetBenchmark         | 100000 | 102,786.02 ns | 24,129.22 ns |  68,450.60 ns |  87,100.0 ns |     400 B |
| ContainsBenchmark    | 100000 | 281,444.51 ns | 42,602.85 ns | 119,462.96 ns | 239,050.0 ns |     400 B |
