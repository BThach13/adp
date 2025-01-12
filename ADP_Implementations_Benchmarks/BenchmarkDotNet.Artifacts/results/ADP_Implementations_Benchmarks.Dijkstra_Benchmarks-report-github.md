```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
11th Gen Intel Core i7-1195G7 2.90GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.402
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method               | N    | Mean          | Error         | StdDev        | Gen0       | Gen1     | Allocated    |
|--------------------- |----- |--------------:|--------------:|--------------:|-----------:|---------:|-------------:|
| **DijkstraShortestPath** | **10**   |      **8.298 μs** |     **0.1311 μs** |     **0.1226 μs** |     **2.8076** |        **-** |     **17.21 KB** |
| **DijkstraShortestPath** | **100**  |    **714.761 μs** |    **13.0825 μs** |    **12.2374 μs** |   **256.8359** |   **7.8125** |   **1575.98 KB** |
| **DijkstraShortestPath** | **1000** | **71,547.286 μs** | **1,155.6329 μs** | **1,080.9797 μs** | **25500.0000** | **500.0000** | **156383.13 KB** |
