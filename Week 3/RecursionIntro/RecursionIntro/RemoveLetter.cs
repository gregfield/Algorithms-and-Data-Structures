using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionIntro
{
    public class RemoveLetter
    {
        public String RemoveIt(String targetChar, String s)
        {
            if(s.Length == 0)
            {
                return s;
            }
            else
            {
                String lastLetter = s.Substring(s.Length - 1, 1);
                if(lastLetter.Equals(targetChar))
                {
                    return RemoveIt(targetChar, s.Substring(0, s.Length - 1));
                }
                else
                {
                    return RemoveIt(targetChar ,s.Substring(0, s.Length - 1)) + lastLetter;
                }
            }
        }
    }
}
