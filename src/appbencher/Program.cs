using appbencher;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BottleneckProcessBenchmark>();
        var sum = BenchmarkRunner.Run<BenchmarkDictionaryLookup>();
    }
}