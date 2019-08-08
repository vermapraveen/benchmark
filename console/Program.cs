using System;
using sut;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {            
            var result1 = SamplesWithSpan.CalculateArraySum_With_Span();

            Console.WriteLine($"With Span: {result1}");

            var result2 = SamplesWithoutSpan.CalculateArraySum_Without_Span();
            Console.WriteLine($"WithOUT Span: {result2}");
        }
    }
}
