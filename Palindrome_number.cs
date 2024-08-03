namespace LeetCodePractice;

public class Palindrome_number
{
    public Palindrome_number()
    {
        int x1 = 121;
        int x2 = -121;
        int x3 = 10;
        var result = IsPalindrome(x3);
        Console.WriteLine($" result is => {result}");
        /*
        https://leetcode.com/problems/palindrome-number/description/
        */
    }
    public bool IsPalindrome(int x) 
    {
        if(x<0)
        {
            return false;
        }
        int reverseInt = 0;
        int temp = x;
        while(temp != 0)
        {
            int remaining = temp % 10;
            reverseInt = (reverseInt * 10) + remaining;
            temp = temp/10;
        }
        return (x == reverseInt);
    }
}
