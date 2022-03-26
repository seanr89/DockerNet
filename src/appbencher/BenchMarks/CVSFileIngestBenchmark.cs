using BenchmarkDotNet.Attributes;

namespace appbencher
{
    public class CVSFileIngestBenchmark
    {
        //private const string csvString = "Code,Maze";
        private static readonly BottleneckProcess process = new BottleneckProcess();
        [Benchmark]
        public void GetLastItem()
        {
           // process.GetLastItem(csvString);
        }
    }
}