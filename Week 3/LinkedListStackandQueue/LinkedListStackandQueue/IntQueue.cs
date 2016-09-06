using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackandQueue
{
    public class IntQueue
    {
        IntNode headNode;
        IntNode tailNode;

        public IntQueue()
        {
            headNode = null;
            tailNode = null;
        }

        //adds an int to the queue
        public void Push(int nodeInfoToAdd)
        {
            IntNode nodeToAdd = new IntNode(nodeInfoToAdd);

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

        //gets an int from the queue and removes it from the list
        public int Pop()
        {
            int popInt = Peek();

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

        //looks at the value that is to be returned next
        public int Peek()
        {
            IntNode peekNode = headNode;

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

        //counts how many values in the queue
        public int Count()
        {
            int count = 0;
            IntNode nodeWalker = headNode;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }
            return count;
        }
    }
}
