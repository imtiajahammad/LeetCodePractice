using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Remove_Duplicates_from_Sorted_Array
    {
        /// <summary>
        /// Given a sorted array nums, remove the duplicates in-place such that each element appears only once and returns the new length.
        /// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        /// </summary>
        /// <param name="nums">integer array</param>
        public Remove_Duplicates_from_Sorted_Array(int[] nums)
        {
            int index = 1;
            if (nums.Length == 0 | nums.Length == 1) { index = nums.Length; }
            for (int i = 1; i < nums.Length; i++)
            {
                Console.WriteLine("nums[i - 1] , nums[i]=>" + nums[i - 1] + "|" + nums[i]);
                if (nums[i - 1] != nums[i])
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            for (int i = 0; i < index; i++)
            {
                Console.Write(nums[i] + "|> ");
            }
            Console.WriteLine("solved array length-" + (index));
        }
    }
}
