using System;
using sut;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {            
            var result1 =  SamplesWithSpan.StringTrim_With_Span();
            Console.WriteLine($"With Span: {new string(result1)}");

            var result2 =  SamplesWithoutSpan.StringTrim_Without_Span();
            Console.WriteLine($"WithOUT Span: {result2}");
        }
    }
}
