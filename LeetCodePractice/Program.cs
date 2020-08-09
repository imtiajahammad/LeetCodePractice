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
            int[] aa = {1,9 ,9,9};
            //int[] aa = { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };
            //int[] aa = { 9,8,7,6,5,4,3,2,1,0};
            int[] resutlt=PlusOne(aa);
            for(int i = 0; i < resutlt.Length; i++)
            {
                Console.Write(resutlt[i] + "  ");
            }
            Console.ReadKey();
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
