using BenchmarkDotNet.Attributes;
using ADP_Implementations.Algorithms;

namespace ADP_Implementations_Benchmarks;

[MemoryDiagnoser]
public class HashTable_Benchmarks
{
    /*
        | Method     | N      | Mean          | Error         | StdDev        | Median        | Gen0      | Gen1      | Gen2      | Allocated  |
        |----------- |------- |--------------:|--------------:|--------------:|--------------:|----------:|----------:|----------:|-----------:|
        | InsertBulk | 10     |      7.504 us |     0.4713 us |     1.3821 us |      7.200 us |         - |         - |         - |     2856 B |
        | Insert     | 10     |      4.418 us |     0.2521 us |     0.7274 us |      4.400 us |         - |         - |         - |      616 B |
        | Get        | 10     |      2.302 us |     0.1469 us |     0.4284 us |      2.300 us |         - |         - |         - |      448 B |
        | Delete     | 10     |      2.723 us |     0.1934 us |     0.5642 us |      2.700 us |         - |         - |         - |      448 B |
        | Update     | 10     |      2.312 us |     0.1594 us |     0.4676 us |      2.200 us |         - |         - |         - |      448 B |

        | InsertBulk | 100    |     49.856 us |     3.9418 us |    11.3097 us |     50.300 us |         - |         - |         - |    24456 B |
        | Insert     | 100    |      4.563 us |     0.2803 us |     0.8041 us |      4.400 us |         - |         - |         - |      616 B |
        | Get        | 100    |      2.515 us |     0.1526 us |     0.4378 us |      2.500 us |         - |         - |         - |      448 B |
        | Delete     | 100    |      2.571 us |     0.1461 us |     0.4168 us |      2.600 us |         - |         - |         - |      448 B |
        | Update     | 100    |      2.202 us |     0.1363 us |     0.3955 us |      2.300 us |         - |         - |         - |      448 B |

        | InsertBulk | 1000   |    323.734 us |    18.3490 us |    49.6076 us |    308.100 us |         - |         - |         - |   240456 B |
        | Insert     | 1000   |      3.832 us |     0.2325 us |     0.6482 us |      3.750 us |         - |         - |         - |      616 B |
        | Get        | 1000   |      2.379 us |     0.1228 us |     0.3443 us |      2.300 us |         - |         - |         - |      448 B |
        | Delete     | 1000   |      3.084 us |     0.2668 us |     0.7525 us |      2.800 us |         - |         - |         - |      448 B |
        | Update     | 1000   |      2.225 us |     0.1014 us |     0.2809 us |      2.200 us |         - |         - |         - |      448 B |

        | InsertBulk | 10000  |  1,472.407 us |    66.9345 us |   184.3570 us |  1,406.400 us |         - |         - |         - |  2400120 B |
        | Insert     | 10000  |      5.609 us |     0.9024 us |     2.5305 us |      5.300 us |         - |         - |         - |      616 B |
        | Get        | 10000  |      6.231 us |     0.8739 us |     2.5493 us |      6.000 us |         - |         - |         - |      448 B |
        | Delete     | 10000  |      7.961 us |     0.9770 us |     2.8188 us |      7.650 us |         - |         - |         - |      448 B |
        | Update     | 10000  |      6.426 us |     1.0353 us |     3.0365 us |      5.900 us |         - |         - |         - |      112 B |

        | InsertBulk | 100000 | 53,964.563 us | 1,071.2049 us | 1,603.3292 us | 53,629.400 us | 4000.0000 | 2000.0000 | 1000.0000 | 24002120 B |
        | Insert     | 100000 |      8.049 us |     0.3992 us |     1.0994 us |      7.900 us |         - |         - |         - |      616 B |
        | Get        | 100000 |      5.880 us |     0.8073 us |     2.3031 us |      6.450 us |         - |         - |         - |      448 B |
        | Delete     | 100000 |      7.126 us |     1.1790 us |     3.4017 us |      8.000 us |         - |         - |         - |      448 B |
        | Update     | 100000 |      5.318 us |     0.8474 us |     2.4450 us |      4.650 us |         - |         - |         - |      448 B |
    */
    private HashTable<int> _hashTable;
    private List<string> _data;
    private Random _randomValue = new Random(36);

    [Params(10, 100, 1000, 10000, 100000)]
    public int N;

    [IterationSetup]
    public void IterationSetup()
    {
        _hashTable = new HashTable<int>(N / 2);
        _data = GenerateKeys(N);

        foreach (var key in _data)
        {
            _hashTable.Insert(key, _randomValue.Next(N));
        }
    }

    [Benchmark]
    public void InsertBulk()
    {
        HashTable<int> _localHashTable = new HashTable<int>(N / 2);

        for (int i = 0; i < N; i++)
        {
           _localHashTable.Insert(Guid.NewGuid().ToString(), _randomValue.Next(N));
        }
    }

    [Benchmark]
    public void Insert()
    {
        _hashTable.Insert(Guid.NewGuid().ToString(), _randomValue.Next(N));
    }

    [Benchmark]
    public void Get()
    {
        _hashTable.Get(GetRandomKey());
    }

    [Benchmark]
    public void Delete()
    {
        _hashTable.Delete(GetRandomKey());
    }

    [Benchmark]
    public void Update()
    {
        _hashTable.Update(GetRandomKey(), _randomValue.Next(N));
    }

    private List<string> GenerateKeys(int count)
    {
        var data = new List<string>(count);
        for (int i = 0; i < count; i++)
        {
            data.Add(Guid.NewGuid().ToString());
        }
        return data;
    }

    private string GetRandomKey()
    {
        int index = _randomValue.Next(_data.Count);
        return _data[index];
    }

}