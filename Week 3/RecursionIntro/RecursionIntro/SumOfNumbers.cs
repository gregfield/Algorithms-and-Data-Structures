using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionIntro
{
    public class SumOfNumbers
    {
        public int SumToN(int input)
        {
            if(input == 1)
            {
                return 1;
            }
            else
            {
                return input + SumToN(input - 1);
            }
        }
    }
}
