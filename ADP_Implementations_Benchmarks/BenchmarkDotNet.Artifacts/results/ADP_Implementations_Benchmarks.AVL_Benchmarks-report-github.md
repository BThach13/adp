```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  Job-YZKLRK : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

InvocationCount=1  UnrollFactor=1  

```
| Method  | N     | Mean       | Error     | StdDev      | Median     | Allocated |
|-------- |------ |-----------:|----------:|------------:|-----------:|----------:|
| **Insert**  | **100**   | **2,954.3 ns** | **190.73 ns** |   **544.16 ns** | **3,050.0 ns** |     **512 B** |
| Remove  | 100   |   955.1 ns |  72.03 ns |   210.12 ns |   900.0 ns |     400 B |
| FindMin | 100   |   193.0 ns |  29.82 ns |    87.91 ns |   200.0 ns |     400 B |
| FindMax | 100   |   242.9 ns |  30.13 ns |    88.36 ns |   250.0 ns |     400 B |
| Find    | 100   |   468.5 ns |  31.06 ns |    87.62 ns |   500.0 ns |     400 B |
| **Insert**  | **1000**  | **2,890.4 ns** | **207.40 ns** |   **591.71 ns** | **2,800.0 ns** |     **512 B** |
| Remove  | 1000  |   964.0 ns |  55.81 ns |   154.66 ns |   900.0 ns |     400 B |
| FindMin | 1000  |   275.5 ns |  22.81 ns |    65.07 ns |   300.0 ns |     400 B |
| FindMax | 1000  |   267.0 ns |  22.63 ns |    64.57 ns |   300.0 ns |     400 B |
| Find    | 1000  |   424.5 ns |  38.47 ns |   112.20 ns |   400.0 ns |     400 B |
| **Insert**  | **10000** | **5,500.0 ns** | **717.96 ns** | **2,036.73 ns** | **5,400.0 ns** |     **512 B** |
| Remove  | 10000 | 1,241.7 ns | 243.04 ns |   701.23 ns | 1,000.0 ns |     400 B |
| FindMin | 10000 |   597.9 ns | 103.69 ns |   297.50 ns |   500.0 ns |     400 B |
| FindMax | 10000 |   515.8 ns | 104.60 ns |   300.11 ns |   400.0 ns |     400 B |
| Find    | 10000 |   695.8 ns | 123.89 ns |   357.45 ns |   600.0 ns |     400 B |