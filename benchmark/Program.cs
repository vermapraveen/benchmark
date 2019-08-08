using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using sut;

namespace benchmark
{
    public class Program
    {
        [MemoryDiagnoser]
        public class ArraySum_WithVsWithout_Span
        {
            [Benchmark(Baseline = true)]
            public void SystemTextJson()
            {
                SamplesWithSpan.Json_Serialize_With_Span();
            }

            [Benchmark]
            public void NewtonsftJson()
            {
                SamplesWithoutSpan.Json_Serialize_Without_Span();
            }
        }

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ArraySum_WithVsWithout_Span>();
        }
    }
}
