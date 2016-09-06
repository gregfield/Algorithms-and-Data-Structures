using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionIntro
{
    public class RecursivePalindrome
    {
        public bool Palindrome(String s)
        {
            if(s.Length < 2)
            {
                return true;
            }
            else
            {
                String front = s.Substring(0, 1);
                String back = s.Substring(s.Length - 1, 1);
                String nextString = s.Substring(1, s.Length - 2);

                if((front.Equals(back)) && (Palindrome(nextString) == true))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
