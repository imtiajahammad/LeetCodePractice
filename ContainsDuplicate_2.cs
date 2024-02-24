using System;

namespace LeetCodePractice
{
    public class ContainsDuplicate_2
    {
        public ContainsDuplicate_2()
        {
            int[] nums = { 1, 2, 3, 1 };
            int[] nums2 = { 1, 2, 3, 4 };
            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool result = ContainsDuplicateFunction(nums3);
            Console.WriteLine($"Contains Duplicate => {result}",result);
        }


        bool ContainsDuplicateFunction(int[] arr)
        {
            Dictionary<int,int> keyValuePairs = new Dictionary<int, int>();
            for(int i=0; i<arr.Length; i++)
            {
                if(keyValuePairs.ContainsKey(arr[i])){
                    return true;
                }
                else{
                    keyValuePairs.Add(arr[i],1);
                }
            }
            return false;
        }
    }
}