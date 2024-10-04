using System.Collections.Concurrent;

namespace BackGroundDemo;

public class SampleData
{
    public ConcurrentBag<string> Data { get; set; } = new();
}
