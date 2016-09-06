using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateRecursion
{
    public class PowersOfThree
    {
        public bool PowerOfThree(int num)
        {
            if (num < 3)
            {
                if(num == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((num % 3) == 0)
                {
                    return PowerOfThree(num / 3);
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
