using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackandQueue
{
    public class IntNode
    {
        public IntNode Next { get; set; }
        public int nodeInfo;

        public IntNode(int nodeInfoToAdd)
        {
            nodeInfo = nodeInfoToAdd;
            Next = null;
        }
    }
}
