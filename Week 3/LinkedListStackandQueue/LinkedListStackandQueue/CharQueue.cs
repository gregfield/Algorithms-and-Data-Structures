using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackandQueue
{
    public class CharQueue
    {
        CharNode headNode;
        CharNode tailNode;

        public CharQueue()
        {
            headNode = null;
            tailNode = null;
        }

        //adds an char to the queue
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

        //gets an char from the queue and removes it from the list
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

                headNode = headNode.Next;
            }
            return popInt;
        }

        //looks at the char that is to be returned next
        public char Peek()
        {
            CharNode peekNode = headNode;

            if(IsEmpty())
            {
                throw new Exception("Nothing in List");
            }
            else
            {
                return peekNode.nodeInfo;
            }
        }

        //checks if the queue is empty
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

        //counts how many chars in the queue
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
