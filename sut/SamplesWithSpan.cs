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

        public static void SelectAndUpdateArrayItem_With_Span()
        {
            var array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            var slice = new Span<int>(array, 2, 5);
            for (int ctr = 0; ctr < slice.Length; ctr++)
                slice[ctr] *= 2;
        }
    }
}
