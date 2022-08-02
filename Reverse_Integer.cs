using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Reverse_Integer
    {
        private int testInteger;
        public Reverse_Integer()
        {
            this.testInteger = 2147483647;
            int result = Reverse(this.testInteger);
            Console.WriteLine(this.testInteger.ToString() + " is reversed to " + result.ToString());
        }

        public int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int reminder = x % 10;
                int temp = result * 10;
                if (result != (temp / 10)) return 0;
                result = (temp) + reminder;
                x = x / 10;
            }
            return result;
        }
    }
}
