using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace LeetCodePractice
{
    public class First_Unique_Character_in_string
    {
        private string stringInSmallLetter;
        public First_Unique_Character_in_string()
        {
            this.stringInSmallLetter = "aabb";//"loveleetcode";// "leetcode";
            int things = First_Unique_Characte(this.stringInSmallLetter);
            Console.WriteLine("first unique char is {0}", things);
        }
        public int First_Unique_Characte(string word)
        {
            char[] chars = word.ToArray();
            char temp;
            for (int i = 0; i < chars.Length; i++)
            {
                bool unique = true;
                temp = word[i];
                Console.WriteLine("i =>{0}--", chars[i]);
                for (int j = i + 1; j < chars.Length; j++)
                {
                    Console.Write(chars[j] + ",");
                    if (temp.Equals(word[j]))
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique)
                {
                    Console.WriteLine("result is {0}", chars[i]);
                    return i;
                }
                Console.WriteLine();
            }
            return -1;
        }
    }
}
