using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class SelectionSort : ISort
    {
        int opCount;
        public int[] sort(int[] arrayToSort)
        {
            opCount = 0;
            int[] sortedArray = arrayToSort;
            opCount++;
            int arrayIndexNum = arrayToSort.Length - 1;
            opCount++;

            //runs through the array
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                opCount+=2;
                int highest = 0;
                opCount++;
                for (int j = 0; j < arrayIndexNum; j++)
                {
                    opCount+=2;
                    //gets the highest value in the unsorted portion of the array
                    if (sortedArray[j] > sortedArray[highest])
                    {
                        opCount++;
                        highest = j;
                        opCount++;
                    }
                }

                //swaps the highest value in the array with the next highest position in the array
                sortedArray = swap(sortedArray, highest, arrayIndexNum);
                opCount++;

                arrayIndexNum--;
                opCount++;
            }
            opCount++;
            Debug.WriteLine(opCount);
            return sortedArray;
        }

        //swaps to elements in an array
        private int[] swap(int[] array, int pos1, int pos2)
        {
            int temp = array[pos1];
            opCount++;
            array[pos1] = array[pos2];
            opCount++;
            array[pos2] = temp;
            opCount++;

            opCount++;
            return array;
        }
    }
}
