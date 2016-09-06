using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackandQueue
{
    public class PostfixParser
    {
        public int Parser(string postFixInput)
        {
            IntStack intStack = new IntStack();
            int total = 0;
            char[] postixCharArray = postFixInput.ToCharArray();

            //runs through the char array
            for (int i = 0; i < postixCharArray.Length; i++ )
            {
                //if there is a plus sign and there is values in the stack
                if(postixCharArray[i] == '+')
                {
                    if(intStack.Count() != 0)
                    {
                        //if there is only 1 item in the stack it adds to the existing total
                        //if there is more than one it takes the last two values added to the stack
                        //and adds them together
                        if (intStack.Count() == 1)
                        {
                            total += intStack.Pop();
                        }
                        else
                        {
                            total = intStack.Pop() + intStack.Pop();
                        }
                    }
                }
                //if there is a multiplication sign and there is values in the stack
                else if(postixCharArray[i] == '*')
                {
                    //if there is only 1 item in the stack it multiplys to the existing total
                    //if there is more than one it takes the last two values added to the stack
                    //and multiplys them together
                    if (intStack.Count() == 1)
                    {
                        total *= intStack.Pop();
                    }
                    else
                    {
                        total = intStack.Pop() * intStack.Pop();
                    }
                }
                //if there is no operator it must be a number so adds it to the stack as an int
                else
                {
                    intStack.Push(Convert.ToInt32(postixCharArray[i].ToString()));
                }
            }

            return total;
        }
    }
}
