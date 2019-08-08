using System;
using System.Text.Json;

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
            for (int i = 0; i < 1000; i++)
            {
                for (int ctr = 0; ctr < slice.Length; ctr++)
                    slice[ctr] *= 2;
            }
        }

        public static void StringTrim_With_Span()
        {
            string test = "   Hello, World! ";
            for (int i = 0; i < 100; i++)
            {
                Trim(test.ToCharArray()).ToArray();
            }
        }

        public static void Json_Serialize_With_Span()
        {
            var w = new WeatherForecast() { Date = DateTime.Now, TemperatureC = 30, Summary = "Hot" };
            JsonSerializer.Serialize<WeatherForecast>(w);
        }

        private static Span<char> Trim(Span<char> source)
        {
            if (source.IsEmpty)
            {
                return source;
            }

            int start = 0, end = source.Length - 1;
            char startChar = source[start], endChar = source[end];

            while ((start < end) && (startChar == ' ' || endChar == ' '))
            {
                if (startChar == ' ')
                {
                    start++;
                }

                if (endChar == ' ')
                {
                    end--;
                }

                startChar = source[start];
                endChar = source[end];
            }

            return source.Slice(start, end - start + 1);
        }
    }
}
