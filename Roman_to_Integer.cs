using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace LeetCodePractice;

public class Roman_to_Integer
{
    Dictionary<char,int> romanMap = new Dictionary<char, int>(){
        {'I',1}
        ,{'V',5}
        ,{'X',10}
        ,{'L',50}
        ,{'C',100}
        ,{'D',500}
        ,{'M',1000}
    };
    public Roman_to_Integer()
    {
        int result = RomanToInt("III");
        //int result = RomanToInt("XIV");
        //int result = RomanToInt("LVIII");
        //int result = RomanToInt("MCMXCIV");
        Console.WriteLine($"Roman to Integer is -> {result}");
    }
    public int RomanToInt(string s) 
    {
        int sum = 0;
        for(int i=0;i<s.Length;i++)
        {
            if( i == s.Length - 1)
            {
                sum = sum + romanMap[s[i]];
                break;
            }
            if(romanMap[s[i]] >= romanMap[s[i+1]])
            {
                sum = sum + romanMap[s[i]];
            }
            else
            {
                sum = sum + (romanMap[s[i+1]] - romanMap[s[i]]);
                i= i + 1;
            }
        }
        return sum;
    }
}
