using System;

namespace sut
{
    public class SamplesWithoutSpan
    {
        public static int CalculateArraySum_Without_Span()
        {
            var array = new int[10];

            int data = 0;
            for (int ctr = 0; ctr < array.Length; ctr++)
                array[ctr] = data++;

            int arraySum = 0;
            foreach (var value in array)
                arraySum += value;

            return arraySum;
        }
    }
}
