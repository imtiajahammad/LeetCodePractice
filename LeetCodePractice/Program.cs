using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] aa = { 0, 1, 0, 3, 12 };
            int[] aa = { 0, 0, 1 };
            //Output: [1, 3, 12, 0, 0]
            MoveZeroes(aa);
            /*for (int i = 0; i < aa.Length; i++)
            {
                Console.Write(aa[i] + "  ");
            }*/
            Console.ReadKey();
        }
        static void MoveZeroes(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    int index = i;
                    while (index < nums.Length-1)
                    {
                        int temp = nums[index+1];
                        nums[index + 1] = nums[index];
                        nums[index] = temp;
                        index++;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "  ");
            }
        }
        static int[] PlusOne(int[] digits)
        {
            bool added = false;
            for (int i = digits.Length-1; i >= 0 ; i--)
            {
                if (digits[i] != 9 && !added)
                {
                    digits[i] = digits[i] + 1;
                    added = true;
                }
                else if(!added)
                {
                    digits[i] = 0;
                    added = false;
                    if (i == 0 && !added)
                    {
                        List<int> list = digits.ToList();
                        list.Reverse();
                        list.Add(1);
                        list.Reverse();
                        digits = list.ToArray();
                    }
                }
            }
            return digits;// new int[0];
        }
        static int reversDigits(int num)
        {
            int rev_num = 0;
            while (num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num = num / 10;
            }
            return rev_num;
        }
        static int reversDigits2(int num)
        {
            // Handling negative numbers  
            bool negativeFlag = false;
            if (num < 0)
            {
                negativeFlag = true;
                num = -num;
            }

            int prev_rev_num = 0, rev_num = 0;
            while (num != 0)
            {
                int curr_digit = num % 10;
                rev_num = (rev_num * 10) + curr_digit;
                // checking if the reverse overflowed  
                // or not. The values of (rev_num -  
                // curr_digit)/10 and prev_rev_num must  
                // be same if there was no problem.  
                if ((rev_num - curr_digit) / 10 != prev_rev_num)
                {
                    Console.WriteLine("WARNING OVERFLOWED!!!");
                    return 0;
                }

                prev_rev_num = rev_num;
                num = num / 10;
            }

            return (negativeFlag == true) ?
                                 -rev_num : rev_num;
        }
    }
}
