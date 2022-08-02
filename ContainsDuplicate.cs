using System;

namespace LeetCodePractice
{
    public class ContainsDuplicate
    {
        public ContainsDuplicate()
        {
            int[] nums = { 1, 2, 3, 1 };
            int[] nums2 = { 1, 2, 3, 4 };
            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool result = ContainsDuplicateFunction(nums3);
            Console.WriteLine($"Contains Duplicate => {result}",result);
        }


        bool ContainsDuplicateFunction(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int temp = arr[i];
                for (int b = i + 1; b < arr.Length; b++)
                {
                    if (temp == arr[b])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}