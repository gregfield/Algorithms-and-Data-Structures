using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionIntro
{
    public class ReverseString
    {
        public string ReverseIt(String s)
        {
            if(s.Length == 1)
            {
                return s;
            }
            else
            {
                return s.Substring(s.Length - 1, 1) + ReverseIt(s.Substring(0, s.Length - 1));
            }
        }
    }
}
