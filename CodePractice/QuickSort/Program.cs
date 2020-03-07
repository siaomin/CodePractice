using System;

namespace QuickSort
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] nums = new int[] { 16, 7, 85, 23, 99, 1, 43, 36, 5, 84, 47 };

            QuickSort(nums, 0, nums.Length - 1);

            //印結果
            foreach (var i in nums)
            {
                Console.Write(string.Format("{0},", i));
            }

            //暫停畫面
            Console.Read();
        }

        private static void QuickSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                //基數取中間值，減少遇到最差情況(取到最小或最大值且已陣列排序好)的機率
                var mid = (left + right) / 2;
                var changeIndex = left;

                //把基數換到最右邊是為了方便跑下面迴圈
                Switch(nums, right, mid);

                for (var i = left; i < right; i++)
                {
                    //若比基數小就change，比基數大就不動
                    if (nums[i] < nums[right])
                    {
                        Switch(nums, i, changeIndex);
                        changeIndex++;
                    }
                }
                //把基數塞進中間, 比基數小 <--> 基數(塞進這) <--> 比基數大
                Switch(nums, changeIndex, right);
                //遞迴下去，把[比基數小]跟把[比基數大]丟進去繼續排列
                QuickSort(nums, left, changeIndex - 1);
                QuickSort(nums, changeIndex + 1, right);
            }
        }

        private static void Switch(int[] nums, int indexA, int indexB)
        {
            var a = nums[indexA];
            nums[indexA] = nums[indexB];
            nums[indexB] = a;
        }
    }
}