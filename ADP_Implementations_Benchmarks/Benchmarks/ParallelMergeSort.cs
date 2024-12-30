using BenchmarkDotNet.Attributes;
using ADP_Implementations.Algorithms;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class ParallelMergeSort_Benchmarks
{
    /*
        | Method                     | N      | Mean          | Error         | StdDev        | Median        | Gen0      | Gen1      | Allocated  |
        |--------------------------- |------- |--------------:|--------------:|--------------:|--------------:|----------:|----------:|-----------:|
        | ParallelSortWithTreshold1  | 10     |     38.039 us |     2.9931 us |     8.6834 us |     37.400 us |         - |         - |     5768 B |
        | ParallelSortWithTreshold2  | 10     |     44.124 us |     4.5919 us |    12.9517 us |     44.050 us |         - |         - |     5880 B |
        | ParallelSortWithTreshold4  | 10     |     46.853 us |     3.8360 us |    11.0063 us |     45.550 us |         - |         - |     5880 B |
        | ParallelSortWithTreshold6  | 10     |     43.537 us |     4.0765 us |    11.8266 us |     40.800 us |         - |         - |     5880 B |
        | ParallelSortWithTreshold10 | 10     |      2.299 us |     0.1119 us |     0.3281 us |      2.200 us |         - |         - |     1528 B |
        | ParalleleOnlySort          | 10     |     43.629 us |     3.2570 us |     9.3972 us |     41.800 us |         - |         - |     5880 B |
        | SeqOnlySort                | 10     |      1.917 us |     0.0784 us |     0.2249 us |      1.900 us |         - |         - |      768 B |

        | ParallelSortWithTreshold1  | 100    |     83.235 us |     5.0780 us |    14.8930 us |     85.100 us |         - |         - |    56208 B |
        | ParallelSortWithTreshold2  | 100    |     80.410 us |     6.8668 us |    19.8122 us |     79.550 us |         - |         - |    56320 B |
        | ParallelSortWithTreshold4  | 100    |     84.929 us |     5.7305 us |    16.5338 us |     85.400 us |         - |         - |    56520 B |
        | ParallelSortWithTreshold6  | 100    |     88.693 us |     6.9722 us |    20.2276 us |     88.200 us |         - |         - |    56096 B |
        | ParallelSortWithTreshold10 | 100    |     86.940 us |     5.5471 us |    16.2688 us |     89.000 us |         - |         - |    56320 B |
        | ParalleleOnlySort          | 100    |     94.838 us |     5.5497 us |    15.8335 us |     94.300 us |         - |         - |    56320 B |
        | SeqOnlySort                | 100    |     23.843 us |     0.9683 us |     2.7784 us |     24.000 us |         - |         - |     5624 B |

        | ParallelSortWithTreshold1  | 1000   |    279.575 us |     6.7557 us |    19.1648 us |    277.700 us |         - |         - |   570752 B |
        | ParallelSortWithTreshold2  | 1000   |    308.522 us |     6.9246 us |    19.7563 us |    306.950 us |         - |         - |   570776 B |
        | ParallelSortWithTreshold4  | 1000   |    301.560 us |     9.8648 us |    28.3038 us |    299.300 us |         - |         - |   571320 B |
        | ParallelSortWithTreshold6  | 1000   |    282.017 us |     7.3001 us |    20.3497 us |    277.850 us |         - |         - |   570240 B |
        | ParallelSortWithTreshold10 | 1000   |    314.819 us |     7.4977 us |    21.5124 us |    314.000 us |         - |         - |   570896 B |
        | ParalleleOnlySort          | 1000   |    282.638 us |     6.9661 us |    19.7616 us |    281.100 us |         - |         - |   571296 B |
        | SeqOnlySort                | 1000   |    230.887 us |     4.5063 us |    11.3880 us |    229.500 us |         - |         - |    64728 B |

        | ParallelSortWithTreshold1  | 10000  |  2,680.263 us |   113.5534 us |   334.8148 us |  2,640.600 us |         - |         - |  5835952 B |
        | ParallelSortWithTreshold2  | 10000  |  2,527.801 us |   138.5772 us |   404.2364 us |  2,441.400 us |         - |         - |  5835880 B |
        | ParallelSortWithTreshold4  | 10000  |  2,569.045 us |   151.6975 us |   440.1020 us |  2,421.400 us |         - |         - |  5836744 B |
        | ParallelSortWithTreshold6  | 10000  |  2,459.089 us |    84.4207 us |   244.9198 us |  2,475.400 us |         - |         - |  5836856 B |
        | ParallelSortWithTreshold10 | 10000  |  2,599.945 us |   130.0672 us |   383.5060 us |  2,652.500 us |         - |         - |  5835520 B |
        | ParalleleOnlySort          | 10000  |  2,584.200 us |   161.3736 us |   468.1740 us |  2,509.400 us |         - |         - |  5836880 B |
        | SeqOnlySort                | 10000  |  1,902.305 us |   254.3988 us |   750.1006 us |  2,255.500 us |         - |         - |   792440 B |

        | ParallelSortWithTreshold1  | 100000 | 20,649.171 us | 2,193.8750 us | 6,434.2562 us | 17,117.400 us | 9000.0000 |         - | 59634712 B |
        | ParallelSortWithTreshold2  | 100000 | 20,125.658 us | 1,767.2242 us | 5,098.8463 us | 17,761.000 us | 9000.0000 |         - | 59637624 B |
        | ParallelSortWithTreshold4  | 100000 | 17,507.568 us |   516.2535 us | 1,377.9851 us | 17,099.250 us | 9000.0000 | 1000.0000 | 59636720 B |
        | ParallelSortWithTreshold6  | 100000 | 20,099.330 us |   546.9119 us | 1,459.8188 us | 19,725.000 us | 9000.0000 |         - | 59637112 B |
        | ParallelSortWithTreshold10 | 100000 | 19,663.997 us |   451.9474 us | 1,237.1989 us | 19,368.100 us | 9000.0000 |         - | 59636680 B |
        | ParalleleOnlySort          | 100000 | 20,142.794 us |   499.2868 us | 1,349.8509 us | 20,176.900 us | 9000.0000 | 1000.0000 | 59637344 B |
        | SeqOnlySort                | 100000 |  9,573.760 us |   190.2120 us |   542.6857 us |  9,503.750 us | 1000.0000 |         - |  9231608 B |
    */
    private int[] _array = null!;
    private Random _random = new Random(36);

    [Params(10, 100, 1000, 10000, 100000)]
    public int N;

    [IterationSetup]
    public void IterationSetup()
    {
        _array = new int[N];

        for (int i = 0; i < N; i++)
        {
           _array[i] = _random.Next(N);
        }
    }

    [Benchmark]
    public void ParallelSortWithTreshold1()
    {
        ParallelMergeSort.Sort(_array, 0, _array.Length, 1);
    }

    [Benchmark]
    public void ParallelSortWithTreshold2()
    {
        ParallelMergeSort.Sort(_array, 0, _array.Length, 2);
    }

    [Benchmark]
    public void ParallelSortWithTreshold4()
    {
        ParallelMergeSort.Sort(_array, 0, _array.Length, 4);
    }

    [Benchmark]
    public void ParallelSortWithTreshold6()
    {
        ParallelMergeSort.Sort(_array, 0, _array.Length, 8);
    }

    [Benchmark]
    public void ParallelSortWithTreshold10()
    {
        ParallelMergeSort.Sort(_array, 0, _array.Length, 10);
    }

    [Benchmark]
    public void ParalleleOnlySort()
    {
        ParallelMergeSort.SortParallel(_array, 0, _array.Length);
    }

    [Benchmark]
    public void SeqOnlySort()
    {
        ParallelMergeSort.SortSeq(_array, 0, _array.Length);
    }
}