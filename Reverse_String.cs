using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Reverse_String
    {
        char[] s = { 'h', 'e', 'l', 'l', 'o' };
        public Reverse_String()
        {


            helper(s, 0, s.Length - 1);



            for (int j = 0; j < s.Length; j++)
            {
                Console.Write(s[j] + " |");
            }


            Console.WriteLine();
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                char tempV = s[left];
                s[left++] = s[right];
                s[right--] = tempV;
            }
            for (int j = 0; j < s.Length; j++)
            {
                Console.Write(s[j] + " |");
            }


        }
        public void helper(char[] a, int left, int right)
        {
            if (left >= right) { return; }
            char leftV = a[left];
            a[left] = a[right];
            a[right] = leftV;
            helper(a, left + 1, right - 1);
        }
        public void Reverse_String_function1()
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                char tempV = s[left];
                s[left++] = s[right];
                s[right--] = tempV;
            }
        }
        public void Reverse_String_function2()
        {
            helper(s, 0, s.Length - 1);
        }
    }
}
