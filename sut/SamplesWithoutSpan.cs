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

        public static void SelectAndUpdateArrayItem_Without_Span()
        {
            var array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            for (int ctr = 2; ctr < 5; ctr++)
                array[ctr] *= 2;
        }
    }
}
