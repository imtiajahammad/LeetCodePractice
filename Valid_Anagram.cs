using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Valid_Anagram
    {
        public Valid_Anagram()
        {
            string s = "anagram", t = "nagaram";
            string s2 = "rat", t2 = "car";
            var result = IsAnagram2(s, t);
            Console.WriteLine($"Is Anagram => {result}", result);

        }

        public bool IsAnagram(string s, string t)
        {
            Hashtable sht = new Hashtable();
            Hashtable tht = new Hashtable();
            char[] sToChars = s.ToCharArray();
            char[] tToChars = t.ToCharArray();
            if (sToChars.Length != tToChars.Length)
            {
                return false;
            }
            for(int i = 0; i < sToChars.Length; i++)
            {
                if (sht.ContainsKey(sToChars[i]))
                {
                    int value = (int)sht[sToChars[i]];
                    sht[sToChars[i]] = value + 1;
                }
                else 
                {
                    sht.Add(sToChars[i], 1);
                }
                if (tht.ContainsKey(tToChars[i]))
                {
                    int value = (int)tht[tToChars[i]];
                    tht[tToChars[i]] = value + 1;
                }
                else
                {
                    tht.Add(tToChars[i], 1);
                }
            }

            foreach(char a in sht.Keys)
            {
                var asht = ( sht[a] == null ) ? 0: (int)sht[a];
                var atht = ( tht[a] == null )? 0: (int)tht[a]; 
                if ( asht != atht )
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsAnagram2(string s, string t)
        {

            var val1 = s.ToCharArray();
            var val2 = t.ToCharArray();
            Array.Sort(val1);
            Array.Sort(val2);
            if( new String(val1) == new string(val2))
            {
                return true;
            }
            return false;
        }
    }
}
