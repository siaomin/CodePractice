using System;

namespace SelectSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var testData = new int[] { 5, 3, 8, 1, 4, 7, 2, 9, 6 };
            var minIndex = 0;
            for (var i = 0; i < testData.Length - 1; i++)
            {
                minIndex = i;

                for (var j = i + 1; j < testData.Length; j++)
                {
                    if (testData[minIndex] > testData[j])
                    {
                        minIndex = j;
                    }
                }

                var temp = testData[i];
                testData[i] = testData[minIndex];
                testData[minIndex] = temp;
            }

            var result = string.Join(",", testData);

            Console.WriteLine(result);

            //暫停畫面
            Console.Read();
        }
    }
}