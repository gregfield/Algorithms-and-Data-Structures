using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackandQueue
{
    public class BalancedBraces
    {
        List<string> stringsToTest;

        //reads in the file for testing
        public void ReadInFile()
        {
            StreamReader sr = new StreamReader("C:/Users/Greg/Documents/GitHub/IN711fielgm2/Week 3/LinkedListStackandQueue/LinkedListStackandQueue/bin/Debug/Braces.txt");
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                stringsToTest.Add(line);
            }
        }

        //checks the file and returns whether each line is correct or not
        public bool[] checkFile()
        {
            stringsToTest = new List<string>();
            ReadInFile();

            bool[] results = new bool[stringsToTest.Count];
            int count = 0;
            foreach(string line in stringsToTest)
            {
                results[count] = checkString(line);
                count++;
            }

            return results;
        }

        //checks for balanced braces
        public bool checkString(string stringToTest)
        {
            bool isBalanced = true;
            CharStack charStack = new CharStack();
            char[] stringChars = stringToTest.ToCharArray();

            //runs through the char array of the string 
            for (int i = 0; i < stringChars.Length; i++ )
            {
                //when it finds an opening brace it adds it to the stack
                if(stringChars[i] == '{')
                {
                    charStack.Push(stringChars[i]);
                }
                //when it finds a closing brace if the stack is empty it returns false as there is not a
                //opening brace in the stack so they are not balanced
                //if the stack is not empty it pops a brace from the stack
                else if(stringChars[i] == '}')
                {
                    if(charStack.Count() == 0)
                    {
                        isBalanced = false;
                    }
                    else
                    {
                        charStack.Pop();
                    }
                }
            }

            //if the stack does not equal 0 it returns false for it not being balanced as there is
            //left over opening braces in the stack meaning that there where some that are not closed
            if(charStack.Count() != 0)
            {
                isBalanced = false;
            }

            return isBalanced;
        }
    }
}
