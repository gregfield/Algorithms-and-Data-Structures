using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class BubbleSort : ISort
    {
        int opCount;
        public int[] sort(int[] arrayToSort)
        {
            opCount = 0;
            int[] sortedArray = arrayToSort;
            opCount++;
            //runs through the array
            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                opCount += 2;
                for (int j = 0; j < arrayToSort.Length - 1; j++)
                {
                    opCount += 2;
                    //swaps elements if the first one is bigger than the second
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        opCount++;
                        swap(sortedArray, j, j + 1);
                        opCount++;
                    }
                }
            }
            opCount++;//for return
            Debug.WriteLine(opCount);
            return sortedArray;
        }

        //swaps elements in an array
        private int[] swap(int[] array, int pos1, int pos2)
        {
            int temp = array[pos1];
            opCount++;
            array[pos1] = array[pos2];
            opCount++;
            array[pos2] = temp;
            opCount++;

            opCount++;///for return
            return array;
        }
    }
}
