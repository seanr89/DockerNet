using appbencher;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello User!");
        //var summary = BenchmarkRunner.Run<BottleneckProcessBenchmark>();
        //var sum = BenchmarkRunner.Run<BenchmarkDictionaryLookup>();
        //var csvSum = BenchmarkRunner.Run<CVSFileIngestBenchmark>();
    }
}