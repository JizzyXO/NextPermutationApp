using System;

namespace NextPermutationApp
{
    public class Program
    {
        public static void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }
            Array.Reverse(nums, i + 1, nums.Length - i - 1);
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            NextPermutation(nums);
            Console.WriteLine(string.Join(", ", nums)); // Output: 1, 3, 2
        }
    }
}