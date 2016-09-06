using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackandQueue
{
    public class CharStack
    {
        CharNode headNode;
        CharNode tailNode;

        public CharStack()
        {
            headNode = null;
            tailNode = null;
        }

        //adds an char to the stack
        public void Push(char nodeInfoToAdd)
        {
            CharNode nodeToAdd = new CharNode(nodeInfoToAdd);

            if(IsEmpty())
            {
                headNode = nodeToAdd;
                tailNode = nodeToAdd;
            }
            else
            {
                tailNode.Next = nodeToAdd;
                tailNode = nodeToAdd;
            }
        }

        //gets an char from the stack and removes it from the list
        public char Pop()
        {
            char popInt = Peek();

            if(headNode == tailNode)
            {
                headNode = null;
                tailNode = null;
            }
            else
            {
                CharNode nodeWalker = headNode;

                while (nodeWalker.Next != tailNode)
                    nodeWalker = nodeWalker.Next;

                if(nodeWalker.Next == tailNode)
                {
                    tailNode = nodeWalker;
                    nodeWalker.Next = null;
                }
            }
            return popInt;
        }

        //looks at the char that is to be returned next
        public char Peek()
        {
            CharNode peekNode = tailNode;

            if(IsEmpty())
            {
                throw new Exception("Nothing in List");
            }
            else
            {
                return peekNode.nodeInfo;
            }
        }

        //checks if the stack is empty
        public bool IsEmpty()
        {
            if((headNode == tailNode) && (tailNode == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //counts how many chars in the stack
        public int Count()
        {
            int count = 0;
            CharNode nodeWalker = headNode;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }
            return count;
        }
    }
}
