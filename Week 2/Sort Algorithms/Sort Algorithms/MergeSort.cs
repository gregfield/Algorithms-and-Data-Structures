using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Algorithms
{
    public class MergeSort : ISort
    {
        const int MAX_DATA = 8192;
        const int DEFAULT_SET_SIZE = 16;
        const int MAX_VALUE = 100;

        public int[] DataArray { get; set; }
        public int CurrentN { get; set; }

        public int[] sort(int[] arrayToSort)
        {
            int low1, high1, low2, high2;
            int setSize= 16;
            // start with Groups of 1
            int groupLength = 1;

            while (groupLength < setSize)
            {

                low1 = 0;
                high1 = low1 + groupLength - 1;

                //Bounds of second group
                low2 = low1 + groupLength;
                high2 = low2 + groupLength - 1;



                while (high2 <= setSize)
                {

                    mergeArraySegments(arrayToSort, low1, high1, low2, high2);

                    // move indices up to next two groups
                    low1 = low1 + (2 * groupLength);
                    high1 = low1 + groupLength - 1;

                    low2 = low1 + groupLength;
                    high2 = low2 + groupLength - 1;

         
                }

                //next group size...
                groupLength *= 2;


            }
            return arrayToSort;
        }

        //merges two segments of the array
        public int[] mergeArraySegments(int[] inputArray, int low1, int high1, int low2, int high2)
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
            if((index1 > high1)&&(index2 <= high2))
            {
                do
                {
                    mergeBuffer[indexBuffer] = inputArray[index2];
                    index2++;
                    indexBuffer++;
                }while(index2 <= high2);
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
