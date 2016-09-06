using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionIntro
{
    public class RecursiveMergeSort
    {

        public int[] MergeSort(int[] arrayToSort, int low, int high, int setSize)
        {
            setSize /= 2;
            if(setSize <= 1)
            {
                return arrayToSort;
            }
            else
            {
                int mid = (low + high) / 2;
                arrayToSort = MergeSort(arrayToSort, low, mid, setSize);
                arrayToSort = MergeSort(arrayToSort, mid + 1, high, setSize);

                return MergeArraySegments(arrayToSort, low, mid, (mid + 1), high);
            }
            
        }

        public int[] MergeArraySegments(int[] inputArray, int low1, int high1, int low2, int high2)
        {
            int index1, index2, indexBuffer;
            int[] mergeBuffer = new int[inputArray.Length];

            index1 = low1;
            index2 = low2;
            indexBuffer = 0;

            //goes through the array using the low1  and low2 as starting points for each of the sorted portions and
            //takes the lowest number from either of the portions and puts it in the merged array
            while ((index1 <= high1) && (index2 <= high2))
            {
                if (inputArray[index1] < inputArray[index2])
                {
                    mergeBuffer[indexBuffer] = inputArray[index1];
                    index1++;
                }
                else
                {
                    mergeBuffer[indexBuffer] = inputArray[index2];
                    index2++;
                }
                indexBuffer++;
            }

            //gets any elements remaining in the protion that is not in the array and dumps them in
            if ((index1 > high1) && (index2 <= high2))
            {
                do
                {
                    mergeBuffer[indexBuffer] = inputArray[index2];
                    index2++;
                    indexBuffer++;
                } while (index2 <= high2);
            }
            else if ((index2 > high2) && (index1 <= high1))
            {
                do
                {
                    mergeBuffer[indexBuffer] = inputArray[index1];
                    index1++;
                    indexBuffer++;
                } while (index1 <= high1);
            }

            return mergeBuffer;
        }
    }
}
