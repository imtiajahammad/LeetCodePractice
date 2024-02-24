using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Valid_Anagram_2
    {
        public Valid_Anagram_2()
        {
            string s = "anagram", t = "nagaram";
            string s2 = "rat", t2 = "car";
            var result = IsAnagram(s, t);
            Console.WriteLine($"Is Anagram => {result}", result);

        }

        public bool IsAnagram(string s, string t)
        {
            var sortedArr1 = s.ToCharArray();
            var sortedArr2 = t.ToCharArray();
            Array.Sort(sortedArr1);
            Array.Sort(sortedArr2);
            if(new String(sortedArr1).Equals(new String(sortedArr2)))
            {
                return true;
            }
            return false;
        }
    }
}
