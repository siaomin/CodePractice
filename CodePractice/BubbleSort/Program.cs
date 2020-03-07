using System;

namespace BubbleSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var testData = new int[] { 72, 25, 7, 83, 93, 4, 11, 6, 10, 15, 28, 3, 77, 63, 98, 91 };

            for (var i = 0; i < testData.Length - 1; i++)
            {
                for (var j = 0; j < testData.Length - i - 1; j++)
                {
                    if (testData[j] > testData[j + 1])
                    {
                        var temp = testData[j];
                        testData[j] = testData[j + 1];
                        testData[j + 1] = temp;
                    }
                }
            }

            var result = string.Join(",", testData);
            Console.Write(result);
            Console.Read();
        }
    }
}