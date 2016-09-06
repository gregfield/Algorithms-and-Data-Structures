using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class InsertionSort : ISort
    {
        int opCount;
        public int[] sort(int[] arrayToSort)
        {
            opCount = 0;
            int[] sortedArray = arrayToSort;
            opCount++;
            int sortedIndex = 0;
            opCount++;
            int unsortedStart = 1;
            opCount++;

            //runs through the array
            for (int i = unsortedStart; i < sortedArray.Length; i++)
            {
                opCount+=2;
                //sets the value where the sorted portion starts
                sortedIndex = i;
                opCount++;
                while (sortedIndex > 0)
                {
                    opCount++;
                    //go through the array till it reaches the end of the sorted portion
                    if (sortedArray[sortedIndex - 1] > sortedArray[sortedIndex])
                    {
                        opCount++;
                        //move the sorted elements along to make room for the new element
                        int temp = sortedArray[sortedIndex - 1];
                        opCount++;
                        sortedArray[sortedIndex - 1] = sortedArray[sortedIndex];
                        opCount++;
                        sortedArray[sortedIndex] = temp;
                        opCount++;
                        sortedIndex--;
                        opCount++;
                    }
                    else
                    {
                        //needed or will get stuck in continuous loop
                        opCount++;
                        break;
                    }
                }
            }
            opCount++;
            Debug.WriteLine(opCount);
            return sortedArray;
        }
    }
}
