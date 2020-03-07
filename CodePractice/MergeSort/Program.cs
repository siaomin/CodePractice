using System;

namespace MergeSort
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] nums = new int[] { 16, 7, 85, 23, 99, 1, 43, 36, 5, 84, 47 };
            Divide(nums, 0, nums.Length - 1);
            foreach (var i in nums)
            {
                Console.Write(i + "->");
            }

            //暫停畫面
            Console.Read();
        }

        private static void Divide(int[] nums, int first, int end)
        {
            if (first < end)
            {
                int mid = (first + end) / 2;
                Divide(nums, first, mid);
                Divide(nums, mid + 1, end);
                Sort(nums, first, mid, end);
            }
        }

        private static void Sort(int[] nums, int first, int mid, int end)
        {
            int aLength = mid - first + 1;
            int bLength = end - mid;
            int[] A = new int[aLength];
            int[] B = new int[bLength];

            for (var i = 0; i < aLength; i++)
            {
                A[i] = nums[first + i];
            }

            for (var j = 0; j < bLength; j++)
            {
                B[j] = nums[mid + 1 + j];
            }

            int aIndex = 0, bIndex = 0, index = first;
            while (aIndex < A.Length && bIndex < B.Length)
            {
                if (A[aIndex] <= B[bIndex])
                {
                    nums[index] = A[aIndex];
                    aIndex++;
                }
                else
                {
                    nums[index] = B[bIndex];
                    bIndex++;
                }
                index++;
            }

            while (aIndex < A.Length)
            {
                nums[index] = A[aIndex];
                aIndex++;
                index++;
            }
            while (bIndex < B.Length)
            {
                nums[index] = B[bIndex];
                bIndex++;
                index++;
            }
        }
    }
}