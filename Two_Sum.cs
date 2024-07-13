using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace LeetCodePractice
{
    public class Two_Sum
    {
        public Two_Sum()
        {
            //int[] array1 = {2,7,11,15}; int target = 9;
            //int[] array2 = {3,2,4}; int target = 6;
            int[] array3 = {3, 3};int target = 6;
            string s2 = "rat", t2 = "car";
            var result = TwoSum(array3, target);
            Console.WriteLine($" target with => {result[0]} and {result[1]} position makes a sum of {target}");
            /*       https://leetcode.com/problems/two-sum/description/   */
        }
        
        public int[] TwoSum(int[] nums, int target) 
        {
            for(int i = 0; i < nums.Length-1; i++)
            {
                for(int j = i+1; j < nums.Length; j++)  
                {
                    if(nums[i]+nums[j] == target) return new int[] {i,j};
                }
            }
            return null;
        }
    }
}
