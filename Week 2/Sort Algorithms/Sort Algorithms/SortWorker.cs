using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_Algorithms
{
    public class SortWorker
    {
        ListBox listbox;

        public SortWorker(ListBox listbox)
        {
            this.listbox = listbox;
        }

        public void runSort(ISort sortType, int arraySize)
        {
            int[] arrayToSort = makeArray(arraySize);
            display(sortType.sort(arrayToSort));
        }

        public int[] makeArray(int arraySize)
        {
            Random rand = new Random();
            int[] arrayToSort = new int[arraySize];

            for (int i = 0; i < arrayToSort.Length; i++ )
            {
                arrayToSort[i] = rand.Next(999);
            }

            return arrayToSort;
        }

        public void display(int[] arrayToDisplay)
        {
            for(int i = 0; i < arrayToDisplay.Length; i++)
            {
                listbox.Items.Add(arrayToDisplay[i]);
            }
        }
    }
}
