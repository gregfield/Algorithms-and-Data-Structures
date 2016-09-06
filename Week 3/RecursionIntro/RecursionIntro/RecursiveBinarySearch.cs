using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionIntro
{
    public class RecursiveBinarySearch
    {
        public bool BinarySearch(int[] dataValues, int target, int lowerbound, int upperbound)
        {
            //if the bounds have crossed the item wass not found so it returns null
            if (lowerbound > upperbound)
            {
                return false;
            }
            else
            {
                //find the midpoint
                int midpoint = (upperbound + lowerbound) / 2;
                //if they are equal it has found the required number
                if (target == dataValues[midpoint])
                {
                    return true;
                }
                //if the target is smaller than the midpoint it makes the new upper bound the midpoint
                else if (target < dataValues[midpoint])
                {
                    return BinarySearch(dataValues, target, lowerbound, midpoint - 1);
                }
                //else it must mean that the target is bigger so it makes the nw lower bound the midpoint
                else
                {
                    return BinarySearch(dataValues, target, midpoint + 1, upperbound);
                }
            }
        }
    }
}
