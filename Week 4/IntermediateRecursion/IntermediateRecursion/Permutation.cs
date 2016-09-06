using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntermediateRecursion
{
    public class Permutation
    {
        //needed to put to 1 in the array and to increase to get it to work
        private const int STARTPOINT = 1;
        private int[] numArray;

        public Permutation(int num)
        {
            numArray = new int[num + STARTPOINT];
        }


        public void Permutations(int index, int num, RichTextBox textBox)
        {
            if(index == numArray.Length)
            {
                //build string
                string newString = "";
                for (int i = STARTPOINT; i < numArray.Length; i++)
                {
                    newString += numArray[i].ToString();
                }
                textBox.AppendText(newString + Environment.NewLine);
            }
            else
            {
                //runs from 1 to the number that was entered
                for (int i = STARTPOINT; i < num + STARTPOINT; i++)
                {
                    //add number to array
                    numArray[index] = i;
                    //recurse to make the next number
                    Permutations(index + 1, num, textBox);
                }
            }
        }
    }
}
