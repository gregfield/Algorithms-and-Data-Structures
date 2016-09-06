using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackandQueue
{
    public class PalindromeFinder
    {
        public bool SearchWord(string wordToCheck)
        {
            CharStack stack = new CharStack();
            CharQueue queue = new CharQueue();

            bool isPalindrome = true;

            char[] word = wordToCheck.ToCharArray();

            //loads the word into the stack and queue so it can be searched through
            for (int i = 0; i < word.Length; i++ )
            {
                stack.Push(word[i]);
                queue.Push(word[i]);
            }

            //runs through the stack and queue until they are empty or there is letters that do not match
            //at which point it exits the loop and returns false for the word is not a palindrome
            while((stack.Count() > 0) && (isPalindrome == true))
            {
                //checks the letters against each other looking for differences
                if(stack.Pop() != queue.Pop())
                {
                    isPalindrome = false;
                }
            }

            return isPalindrome;
        }
    }
}
