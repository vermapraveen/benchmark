using System;

namespace sut
{
    public class SamplesWithSpan
    {
        public static int CalculateArraySum_With_Span()
        {
            var array = new int[10];
            var arraySpan = new Span<int>(array);

            int data = 0;
            for (int ctr = 0; ctr < arraySpan.Length; ctr++)
                arraySpan[ctr] = data++;

            int arraySum = 0;
            foreach (var value in array)
                arraySum += value;

            return arraySum;    
        }
    }
}
