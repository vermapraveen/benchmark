using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using sut;

namespace benchmark
{
    public class Program
    {
        public class ArraySum_WithVsWithout_Span
        {
            [Benchmark(Baseline = true)]
            public void WithSpan()
            {
                SamplesWithSpan.CalculateArraySum_With_Span();
            }

            [Benchmark]
            public void WithoutSpan()
            {
                SamplesWithoutSpan.CalculateArraySum_Without_Span();
            }
        }

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ArraySum_WithVsWithout_Span>();
        }
    }
}
